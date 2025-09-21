Dette er et program der tjekker brugerens adgang baseret på brugernavn, adgangskode og bruger-ID.

**Hvordan bruges det?**
- En bruger er admin hvis brugerID er større end 65536.  
- Brugernavnet skal have mindst 3 tegn.  
- Adgangskoden skal indeholde mindst ét af tegnene: $,|, @.  
- Adgangskoden skal være mindst 20 tegn lang for en admin og 16 tegn for en ikke-admin.  
