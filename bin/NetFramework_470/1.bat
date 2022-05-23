@echo on
for /l %%x in (1, 1, 10) do (
   taskkill /IM ozy_test.exe /F
)
timeout /t 1