# 30 - 60 - 90 formula for Excel

```excel
=IF('sheet1'[age] < 30, "<30",IF(AND('sheet1'[age] >= 30,'sheet1'[age] < 60),"30-60", IF(AND('sheet1'[age] >= 60, 'sheet1'[age] < 90), "60-90", IF('sheet1'[age] >= 90, "90+", "NULL"))))
```
