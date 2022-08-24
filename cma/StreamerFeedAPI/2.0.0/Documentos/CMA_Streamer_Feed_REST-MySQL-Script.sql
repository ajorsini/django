-- 
-- Script d criação para CMA StreamerFeed REST - MySQL
-- 
-- Versão 1.0 - 14/05/2021: Inicial
-- 

--
-- Database CMAStreamerFeed
--
DROP DATABASE IF EXISTS `CMAStreamerFeed`;
CREATE DATABASE `CMAStreamerFeed`;
USE `CMAStreamerFeed`;
--
-- Table Domain
--
DROP TABLE IF EXISTS `Domain`;
CREATE TABLE `Domain` (
  `DomainId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(450) CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`DomainId`),
  UNIQUE KEY `IX_Domain_Name` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
INSERT INTO `Domain` VALUES (1,'streamerfeedapi');
--
-- Table Template
--
DROP TABLE IF EXISTS `Template`;
CREATE TABLE `Template` (
  `TemplateId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(250) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Description` varchar(500) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Content` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`TemplateId`),
  UNIQUE KEY `IX_Template_Name` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
INSERT INTO `Template` VALUES (1,'template-txt-cotacao','Template TXT de Cotacao','Template customizado default de Cotação CMA\r\n\r\n{% for q in Model %}\r\n	Dados da Resposta para {{ q.Data.Symbol.SymbolID }}:\r\n	\r\n		\"Symbol\": \"SymbolID\": {{ q.Data.Symbol.SymbolID }}, \"SourceID\": {{ q.Data.Symbol.SourceID }},\r\n		\"LastTradePrice\": {{ q.Data.LastTradePrice }}\r\n		\"LastTradeQty\": {{ q.Data.LastTradeQty }}\r\n		\"Change\": {{ q.Data.Change }}\r\n		\"Tendency\": {{ q.Data.Tendency }}\r\n		\"LastTradeTime\": {{ q.Data.LastTradeTime }}\r\n		\"AskQty\": {{ q.Data.AskQty }}\r\n		\"AskPrice\": {{ q.Data.AskPrice }}\r\n		\"BidQty\": {{ q.Data.BidQty }}\r\n		\"BidPrice\": {{ q.Data.BidPrice }}\r\n		\"Volume\": {{ q.Data.Volume }}\r\n		\"TradesCount\": {{ q.Data.TradesCount }}\r\n		\"LastTradeDate\": {{ q.Data.LastTradeDate }}\r\n		\"PrevClosePrice\": {{ q.Data.PrevClosePrice }}\r\n		\"OpenPrice\": {{ q.Data.OpenPrice }}\r\n		\"LowPrice\": {{ q.Data.LowPrice }}\r\n		\"AvgPrice\": {{ q.Data.AvgPrice }}\r\n		\"HighPrice\": {{ q.Data.HighPrice }}\r\n		\"ClosePrice\":{{ q.Data.ClosePrice }}\r\n		\"StockDetail\": {{ q.Data.StockDetail }}\r\n		\"StockLength\": {{ q.Data.StockLength }}\r\n		\"MonthChange\": {{ q.Data.MonthChange }}\r\n		\"MonthsChange\": {{ q.Data.MonthsChange }}\r\n		\"YearChange\": {{ q.Data.YearChange }}\r\n		\"CumulativeQuantity\": {{ q.Data.CumulativeQuantity }}\r\n		\"QuoteFactor\": {{ q.Data.QuoteFactor }}\r\n		\"Status\": {{ q.Data.Status }}\r\n		\"ExecPrice\": {{ q.Data.ExecPrice }}\r\n		\"ExecDate\": {{ q.Data.ExecDate }}\r\n		\"AuctionBid\": {{ q.Data.AuctionBid }}\r\n		\"AuctionAsk\": {{ q.Data.AuctionAsk }}\r\n		\"Return\": {{ q.Data.Return }}\r\n		\"Workday\": {{ q.Data.Workday }}\r\n		\"CalendarDays\": {{ q.Data.CalendarDays }}\r\n		\"RemainingDaysToDue\": {{ q.Data.RemainingDaysToDue }}\r\n		\"BidBestOfferNumber\": {{ q.Data.BidBestOfferNumber }}\r\n		\"AskBestOfferNumber\": {{ q.Data.AskBestOfferNumber }}\r\n		\"BidBestOfferBroker\": {{ q.Data.BidBestOfferBroker }}\r\n		\"AskBestOfferBroker\": {{ q.Data.AskBestOfferBroker }}\r\n		\"BidBestOfferQty\": {{ q.Data.BidBestOfferQty }}\r\n		\"AskBestOfferQty\": {{ q.Data.AskBestOfferQty }}\r\n		\"OpenContracts\": {{ q.Data.OpenContracts }}\r\n		\"LastDifferential\": {{ q.Data.LastDifferential }}\r\n\r\n	Status da resposta para {{ q.Data.Symbol.SymbolID }}:\r\n\r\n		\"Success\": {{ q.Status.Success }};\r\n		\"Code\": {{ q.Status.Code }};\r\n		\"OmsCode\": {{ q.Status.OmsCode }};\r\n		\"StreamerCode\": {{ q.Status.StreamerCode }};\r\n		\"Message\": {{ q.Status.Message }};\r\n		\"Referer\": {{ q.Status.Referer }};\r\n		\"UpdatedFields\": {{ q.Status.UpdatedFields }};\r\n		\"IsSnapshot\": {{ q.Status.IsSnapshot }};\r\n		\r\n		\r\n{% endfor %}\r\n');
INSERT INTO `Template` VALUES (2,'template-csv-cotacao','Template CSV de Cotacao','Symbol , LastTradePrice , LastTradeQty , Change , Tendency , LastTradeTime , AskQty , AskPrice , BidQty , BidPrice , Volume , TradesCount , LastTradeDate , PrevClosePrice , OpenPrice , LowPrice , AvgPrice , HighPrice , ClosePrice , StockDetail , StockLength , MonthChange , MonthsChange , YearChange , CumulativeQuantity , QuoteFactor , Status , ExecPrice , ExecDate , AuctionBid , AuctionAsk , Return , Workday , CalendarDays , RemainingDaysToDue , BidBestOfferNumber , AskBestOfferNumber , BidBestOfferBroker , AskBestOfferBroker , BidBestOfferQty , AskBestOfferQty , OpenContracts , LastDifferential{% for q in Model %} {{q.Data.Symbol.SymbolID}} , {{q.Data.LastTradePrice}} , {{q.Data.LastTradeQty}} , {{q.Data.Change}} , {{q.Data.Tendency}} , {{q.Data.LastTradeTime}} , {{q.Data.AskQty}} , {{q.Data.AskPrice}} , {{q.Data.BidQty}} , {{q.Data.BidPrice}} , {{q.Data.Volume}} , {{q.Data.TradesCount}} , {{q.Data.LastTradeDate}} , {{q.Data.PrevClosePrice}} , {{q.Data.OpenPrice}} , {{q.Data.LowPrice}} , {{q.Data.AvgPrice}} , {{q.Data.HighPrice}} , {{q.Data.ClosePrice}} , {{q.Data.StockDetail}} , {{q.Data.StockLength}} , {{q.Data.MonthChange}} , {{q.Data.MonthsChange}} , {{q.Data.YearChange}} , {{q.Data.CumulativeQuantity}} , {{q.Data.QuoteFactor}} , {{q.Data.Status}} , {{q.Data.ExecPrice}} , {{q.Data.ExecDate}} , {{q.Data.AuctionBid}} , {{q.Data.AuctionAsk}} , {{q.Data.Return}} , {{q.Data.Workday}} , {{q.Data.CalendarDays}} , {{q.Data.RemainingDaysToDue}} , {{q.Data.BidBestOfferNumber}} , {{q.Data.AskBestOfferNumber}} , {{q.Data.BidBestOfferBroker}} , {{q.Data.AskBestOfferBroker}} , {{q.Data.BidBestOfferQty}} , {{q.Data.AskBestOfferQty}} , {{q.Data.OpenContracts}} , {{q.Data.LastDifferential}}		{% endfor %}');
INSERT INTO `Template` VALUES (3,'template-html-cotacao','Template HTML Cotacao','<table>	<thead>		<tr>			<th>Symbol</th>			<th>LastTradePrice</th>			<th>LastTradeQty</th>			<th>Change</th>			<th>Tendency</th>			<th>LastTradeTime</th>			<th>AskQty</th>			<th>AskPrice</th>			<th>BidQty</th>			<th>BidPrice</th>			<th>Volume</th>			<th>TradesCount</th>			<th>LastTradeDate</th>			<th>PrevClosePrice</th>			<th>OpenPrice</th>			<th>LowPrice</th>			<th>AvgPrice</th>			<th>HighPrice</th>			<th>ClosePrice</th>			<th>StockDetail</th>			<th>StockLength</th>			<th>MonthChange</th>			<th>MonthsChange</th>			<th>YearChange</th>			<th>CumulativeQuantity</th>			<th>QuoteFactor</th>			<th>Status</th>			<th>ExecPrice</th>			<th>ExecDate</th>			<th>AuctionBid</th>			<th>AuctionAsk</th>			<th>Return</th>			<th>Workday</th>			<th>CalendarDays</th>			<th>RemainingDaysToDue</th>			<th>BidBestOfferNumber</th>			<th>AskBestOfferNumber</th>			<th>BidBestOfferBroker</th>			<th>AskBestOfferBroker</th>			<th>BidBestOfferQty</th>			<th>AskBestOfferQty</th>			<th>OpenContracts</th>			<th>LastDifferential</th>		</tr>	</thead>	<tbody>		{% for q in Model %}		<tr>			<td>{{q.Data.SymbolID}}</td>			<td>{{q.Data.LastTradePrice}}</td>			<td>{{q.Data.LastTradeQty}}</td>			<td>{{q.Data.Change}}</td>			<td>{{q.Data.Tendency}}</td>			<td>{{q.Data.LastTradeTime}}</td>			<td>{{q.Data.AskQty}}</td>			<td>{{q.Data.AskPrice}}</td>			<td>{{q.Data.BidQty}}</td>			<td>{{q.Data.BidPrice}}</td>			<td>{{q.Data.Volume}}</td>			<td>{{q.Data.TradesCount}}</td>			<td>{{q.Data.LastTradeDate}}</td>			<td>{{q.Data.PrevClosePrice}}</td>			<td>{{q.Data.OpenPrice}}</td>			<td>{{q.Data.LowPrice}}</td>			<td>{{q.Data.AvgPrice}}</td>			<td>{{q.Data.HighPrice}}</td>			<td>{{q.Data.ClosePrice}}</td>			<td>{{q.Data.StockDetail}}</td>			<td>{{q.Data.StockLength}}</td>			<td>{{q.Data.MonthChange}}</td>			<td>{{q.Data.MonthsChange}}</td>			<td>{{q.Data.YearChange}}</td>			<td>{{q.Data.CumulativeQuantity}}</td>			<td>{{q.Data.QuoteFactor}}</td>			<td>{{q.Data.Status}}</td>			<td>{{q.Data.ExecPrice}}</td>			<td>{{q.Data.ExecDate}}</td>			<td>{{q.Data.AuctionBid}}</td>			<td>{{q.Data.AuctionAsk}}</td>			<td>{{q.Data.Return}}</td>			<td>{{q.Data.Workday}}</td>			<td>{{q.Data.CalendarDays}}</td>			<td>{{q.Data.RemainingDaysToDue}}</td>			<td>{{q.Data.BidBestOfferNumber}}</td>			<td>{{q.Data.AskBestOfferNumber}}</td>			<td>{{q.Data.BidBestOfferBroker}}</td>			<td>{{q.Data.AskBestOfferBroker}}</td>			<td>{{q.Data.BidBestOfferQty}}</td>			<td>{{q.Data.AskBestOfferQty}}</td>			<td>{{q.Data.OpenContracts}}</td>			<td>{{q.Data.LastDifferential}}</td>		</tr>		{% endfor %}	</tbody></table>');
INSERT INTO `Template` VALUES (4,'exemplo-txt-cotacao','Exemplo TXT de Cotacao','Template de Quotes\n{% for q in Model %}\nSymbolID: {{q.Data.Symbol.SymbolID}}\nLastTradePrice: {{q.Data.LastTradePrice}}\nPrevClosePrice: {{q.Data.PrevClosePrice}}\n{% endfor %}');
INSERT INTO `Template` VALUES (5,'exemplo-html-cotacao','Exemplo HTML de Cotacao','<table><thead><tr><th>Symbol</th><th>LastTradePrice</th><th>PrevClosePrice</th></tr></thead><tbody>\n{% for q in Model %}\n<tr><td>{{q.Data.Symbol.SymbolID}}</td><td>{{q.Data.LastTradePrice}}</td><td>{{q.Data.PrevClosePrice}}</td></tr>\n{% endfor %}\n</tbody></table>\n');
INSERT INTO `Template` VALUES (6,'exemplo-csv-cotacao','Exemplo CSV de Cotacao','Symbol, LastTradePrice, PrevClosePrice\n{% for q in Model %}\n{{q.Data.Symbol.SymbolID}}, {{q.Data.LastTradePrice}}, {{q.Data.PrevClosePrice}}\n{% endfor %}\n');
--
-- Table TemplateDomain
--
DROP TABLE IF EXISTS `TemplateDomain`;
CREATE TABLE `TemplateDomain` (
  `TemplateId` int(11) NOT NULL,
  `DomainId` int(11) NOT NULL,
  `SecondsToRenderedCache` int(11) NOT NULL,
  PRIMARY KEY (`TemplateId`,`DomainId`),
  KEY `IX_TemplateDomain_DomainId` (`DomainId`),
  CONSTRAINT `FK_TemplateDomain_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`DomainId`) ON DELETE CASCADE,
  CONSTRAINT `FK_TemplateDomain_Template_TemplateId` FOREIGN KEY (`TemplateId`) REFERENCES `Template` (`TemplateId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
INSERT INTO `TemplateDomain` VALUES (1,1,0);
INSERT INTO `TemplateDomain` VALUES (2,1,0);
INSERT INTO `TemplateDomain` VALUES (3,1,0);
INSERT INTO `TemplateDomain` VALUES (4,1,0);
INSERT INTO `TemplateDomain` VALUES (5,1,0);
INSERT INTO `TemplateDomain` VALUES (6,1,0);
