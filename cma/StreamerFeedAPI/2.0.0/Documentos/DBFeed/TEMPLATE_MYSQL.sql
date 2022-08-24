CREATE TABLE `TEMPLATE` (
  `ID` int(11) NOT NULL,
  `TEMPLATE` text NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB;
INSERT INTO `TEMPLATE` (`ID`,`TEMPLATE`) VALUES (1,'{% for q in Model %}
    CALL SetBCSYS_ATIVO ("{{q.Data.Symbol.SymbolID}}"
       {% if q.Data.LastTradePrice != empty %}
          ,"{{q.Data.LastTradePrice}}"
       {% else %}
          ,NULL
       {% endif %}
       {% if q.Data.PrevClosePrice != empty %} 
          ,"{{q.Data.PrevClosePrice}}"
       {% else %}
          ,NULL
       {% endif %}
       );
 {% endfor %}');
 