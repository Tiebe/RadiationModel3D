using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium122m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium122m";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 121.91033d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin122()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00261d, new GammaParticle(400270.0, 0.0031)), new(0.00493d, new GammaParticle(947720.0, 0.00131)), new(0.026680000000000002d, new GammaParticle(1013120.0, 0.00122)), new(0.29d, new GammaParticle(1140280.0, 0.00109)), new(0.00261d, new GammaParticle(1274900.0, 0.00097)), new(0.00435d, new GammaParticle(1352150.0, 0.00092)), new(0.01798d, new GammaParticle(1389700.0, 0.00089)), new(0.00522d, new GammaParticle(1634960.0, 0.00076)), new(0.00203d, new GammaParticle(1830600.0, 0.00068)), new(0.01972d, new GammaParticle(2065620.0, 0.0006)), new(0.001015d, new GammaParticle(2153740.0, 0.00058)), new(0.002465d, new GammaParticle(2165500.0, 0.00057)), new(0.00435d, new GammaParticle(2408230.0, 0.00051)), new(0.00551d, new GammaParticle(2415480.0, 0.00051)), new(0.00261d, new GammaParticle(2734600.0, 0.00045)), new(0.03074d, new GammaParticle(2759130.0, 0.00045)), new(0.00232d, new GammaParticle(2775700.0, 0.00045)), new(0.001305d, new GammaParticle(2966000.0, 0.00042)), new(0.008409999999999999d, new GammaParticle(2975700.0, 0.00042)), new(0.00116d, new GammaParticle(3039000.0, 0.00041)), new(0.00116d, new GammaParticle(3582800.0, 0.00035)), new(0.00261d, new GammaParticle(3819700.0, 0.00032)), new(0.00116d, new GammaParticle(4004000.0, 0.00031)), new(0.00145d, new GammaParticle(4106700.0, 0.0003)), new(2.1950450859458e-05d, new GammaParticle(3753.0, 0.33036)), new(6.895270477808238e-05d, new GammaParticle(25044.0, 0.04951)), new(0.0001290524139586045d, new GammaParticle(25271.0, 0.04906)), new(3.6491168916719405e-05d, new GammaParticle(28579.0, 0.04338)), new(4.3679929193313126e-05d, new GammaParticle(28810.0, 0.04304)), new(7.188760276593722e-06d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000474341d },
            { 7000.0d, 0.0000483965d },
            { 14000.0d, 0.0000493621d },
            { 21000.0d, 0.0000503307d },
            { 28000.0d, 0.0000513061d },
            { 35000.0d, 0.000052293d },
            { 42000.0d, 0.0000532945d },
            { 49000.0d, 0.0000543117d },
            { 56000.0d, 0.0000553451d },
            { 63000.0d, 0.0000563943d },
            { 70000.0d, 0.0000574582d },
            { 77000.0d, 0.000058536d },
            { 84000.0d, 0.0000596273d },
            { 91000.0d, 0.0000607286d },
            { 98000.0d, 0.0000618408d },
            { 105000.0d, 0.0000629632d },
            { 115000.0d, 0.0000645803d },
            { 125000.0d, 0.0000662141d },
            { 135000.0d, 0.0000678615d },
            { 145000.0d, 0.0000695217d },
            { 155000.0d, 0.0000711931d },
            { 165000.0d, 0.0000728748d },
            { 175000.0d, 0.0000745657d },
            { 185000.0d, 0.000076265d },
            { 195000.0d, 0.0000779716d },
            { 205000.0d, 0.0000796851d },
            { 215000.0d, 0.0000814046d },
            { 225000.0d, 0.0000831295d },
            { 235000.0d, 0.0000848593d },
            { 245000.0d, 0.0000865933d },
            { 255000.0d, 0.0000883313d },
            { 265000.0d, 0.0000900724d },
            { 275000.0d, 0.0000918166d },
            { 285000.0d, 0.0000935628d },
            { 295000.0d, 0.0000953112d },
            { 305000.0d, 0.000097061d },
            { 315000.0d, 0.0000988121d },
            { 325000.0d, 0.000100564d },
            { 335000.0d, 0.000102316d },
            { 345000.0d, 0.000104068d },
            { 355000.0d, 0.00010582d },
            { 365000.0d, 0.000107572d },
            { 375000.0d, 0.000109322d },
            { 385000.0d, 0.000111071d },
            { 395000.0d, 0.000112818d },
            { 405000.0d, 0.000114564d },
            { 415000.0d, 0.000116307d },
            { 425000.0d, 0.000118048d },
            { 435000.0d, 0.000119786d },
            { 445000.0d, 0.000121521d },
            { 455000.0d, 0.000123252d },
            { 465000.0d, 0.00012498d },
            { 475000.0d, 0.000126704d },
            { 485000.0d, 0.000128424d },
            { 495000.0d, 0.000130139d },
            { 505000.0d, 0.00013185d },
            { 515000.0d, 0.000133555d },
            { 525000.0d, 0.000135256d },
            { 535000.0d, 0.000136951d },
            { 545000.0d, 0.00013864d },
            { 555000.0d, 0.000140324d },
            { 565000.0d, 0.000142002d },
            { 575000.0d, 0.000143673d },
            { 585000.0d, 0.000145338d },
            { 595000.0d, 0.000146996d },
            { 605000.0d, 0.000148646d },
            { 615000.0d, 0.00015029d },
            { 625000.0d, 0.000151927d },
            { 635000.0d, 0.000153556d },
            { 645000.0d, 0.000155177d },
            { 655000.0d, 0.00015679d },
            { 665000.0d, 0.000158395d },
            { 675000.0d, 0.000159992d },
            { 685000.0d, 0.00016158d },
            { 695000.0d, 0.00016316d },
            { 705000.0d, 0.000164731d },
            { 715000.0d, 0.000166292d },
            { 725000.0d, 0.000167845d },
            { 735000.0d, 0.000169388d },
            { 745000.0d, 0.000170922d },
            { 755000.0d, 0.000172446d },
            { 765000.0d, 0.00017396d },
            { 775000.0d, 0.000175465d },
            { 785000.0d, 0.000176959d },
            { 795000.0d, 0.000178443d },
            { 805000.0d, 0.000179917d },
            { 815000.0d, 0.00018138d },
            { 825000.0d, 0.000182833d },
            { 835000.0d, 0.000184274d },
            { 845000.0d, 0.000185705d },
            { 855000.0d, 0.000187125d },
            { 865000.0d, 0.000188534d },
            { 875000.0d, 0.000189931d },
            { 885000.0d, 0.000191317d },
            { 895000.0d, 0.000192692d },
            { 905000.0d, 0.000194055d },
            { 915000.0d, 0.000195406d },
            { 925000.0d, 0.000196746d },
            { 935000.0d, 0.000198073d },
            { 945000.0d, 0.000199389d },
            { 955000.0d, 0.000200693d },
            { 965000.0d, 0.000201984d },
            { 975000.0d, 0.000203263d },
            { 985000.0d, 0.00020453d },
            { 995000.0d, 0.000205785d },
            { 1005000.0d, 0.000207027d },
            { 1026000.0d, 0.000209594d },
            { 1047000.0d, 0.000212104d },
            { 1068000.0d, 0.000214558d },
            { 1089000.0d, 0.000216956d },
            { 1110000.0d, 0.000219296d },
            { 1131000.0d, 0.000221577d },
            { 1152000.0d, 0.0002238d },
            { 1173000.0d, 0.000225964d },
            { 1194000.0d, 0.000228069d },
            { 1215000.0d, 0.000230114d },
            { 1236000.0d, 0.0002321d },
            { 1257000.0d, 0.000234027d },
            { 1278000.0d, 0.000235894d },
            { 1299000.0d, 0.000237701d },
            { 1320000.0d, 0.000239449d },
            { 1341000.0d, 0.000241137d },
            { 1362000.0d, 0.000242766d },
            { 1383000.0d, 0.000244336d },
            { 1404000.0d, 0.000245847d },
            { 1425000.0d, 0.000247299d },
            { 1446000.0d, 0.000248692d },
            { 1467000.0d, 0.000250028d },
            { 1488000.0d, 0.000251306d },
            { 1509000.0d, 0.000252528d },
            { 1530000.0d, 0.000253692d },
            { 1551000.0d, 0.000254801d },
            { 1572000.0d, 0.000255854d },
            { 1593000.0d, 0.000256853d },
            { 1614000.0d, 0.000257798d },
            { 1635000.0d, 0.00025869d },
            { 1656000.0d, 0.000259529d },
            { 1677000.0d, 0.000260316d },
            { 1698000.0d, 0.000261054d },
            { 1719000.0d, 0.000261741d },
            { 1740000.0d, 0.000262379d },
            { 1761000.0d, 0.00026297d },
            { 1782000.0d, 0.000263514d },
            { 1803000.0d, 0.000264013d },
            { 1824000.0d, 0.000264467d },
            { 1845000.0d, 0.000264878d },
            { 1866000.0d, 0.000265247d },
            { 1887000.0d, 0.000265576d },
            { 1908000.0d, 0.000265865d },
            { 1929000.0d, 0.000266116d },
            { 1950000.0d, 0.00026633d },
            { 1971000.0d, 0.00026651d },
            { 1992000.0d, 0.000266655d },
            { 2013000.0d, 0.000266769d },
            { 2034000.0d, 0.000266852d },
            { 2055000.0d, 0.000266906d },
            { 2076000.0d, 0.000266933d },
            { 2097000.0d, 0.000266934d },
            { 2118000.0d, 0.000266911d },
            { 2139000.0d, 0.000266866d },
            { 2160000.0d, 0.000266801d },
            { 2181000.0d, 0.000266717d },
            { 2202000.0d, 0.000266617d },
            { 2223000.0d, 0.0002665d },
            { 2244000.0d, 0.000266369d },
            { 2265000.0d, 0.000266223d },
            { 2286000.0d, 0.000266053d },
            { 2307000.0d, 0.000265861d },
            { 2328000.0d, 0.000265648d },
            { 2349000.0d, 0.000265416d },
            { 2370000.0d, 0.000265166d },
            { 2391000.0d, 0.000264899d },
            { 2412000.0d, 0.000264615d },
            { 2433000.0d, 0.000264317d },
            { 2454000.0d, 0.000264006d },
            { 2475000.0d, 0.000263683d },
            { 2496000.0d, 0.00026333d },
            { 2517000.0d, 0.000262937d },
            { 2538000.0d, 0.000262509d },
            { 2559000.0d, 0.000262044d },
            { 2580000.0d, 0.000261541d },
            { 2601000.0d, 0.000261d },
            { 2622000.0d, 0.000260424d },
            { 2643000.0d, 0.000259811d },
            { 2664000.0d, 0.000259162d },
            { 2685000.0d, 0.000258478d },
            { 2706000.0d, 0.000257761d },
            { 2727000.0d, 0.00025701d },
            { 2748000.0d, 0.000256226d },
            { 2769000.0d, 0.000255411d },
            { 2790000.0d, 0.000254564d },
            { 2811000.0d, 0.000253687d },
            { 2832000.0d, 0.000252779d },
            { 2853000.0d, 0.000251839d },
            { 2874000.0d, 0.000250867d },
            { 2895000.0d, 0.000249864d },
            { 2916000.0d, 0.00024883d },
            { 2937000.0d, 0.000247768d },
            { 2958000.0d, 0.000246676d },
            { 2979000.0d, 0.000245557d },
            { 3000000.0d, 0.00024441d },
            { 3021000.0d, 0.000243237d },
            { 3042000.0d, 0.000242039d },
            { 3063000.0d, 0.000240816d },
            { 3084000.0d, 0.000239569d },
            { 3105000.0d, 0.000238299d },
            { 3126000.0d, 0.000237008d },
            { 3147000.0d, 0.000235695d },
            { 3168000.0d, 0.000234361d },
            { 3189000.0d, 0.000232999d },
            { 3210000.0d, 0.00023161d },
            { 3231000.0d, 0.000230193d },
            { 3252000.0d, 0.000228749d },
            { 3273000.0d, 0.000227279d },
            { 3294000.0d, 0.000225783d },
            { 3315000.0d, 0.000224263d },
            { 3336000.0d, 0.000222718d },
            { 3357000.0d, 0.000221151d },
            { 3378000.0d, 0.000219561d },
            { 3399000.0d, 0.000217949d },
            { 3420000.0d, 0.000216316d },
            { 3441000.0d, 0.000214663d },
            { 3462000.0d, 0.000212992d },
            { 3483000.0d, 0.000211301d },
            { 3504000.0d, 0.000209592d },
            { 3525000.0d, 0.000207867d },
            { 3546000.0d, 0.000206126d },
            { 3567000.0d, 0.00020437d },
            { 3588000.0d, 0.0002026d },
            { 3609000.0d, 0.000200816d },
            { 3630000.0d, 0.000199017d },
            { 3651000.0d, 0.000197204d },
            { 3672000.0d, 0.000195376d },
            { 3693000.0d, 0.000193535d },
            { 3714000.0d, 0.000191683d },
            { 3735000.0d, 0.000189819d },
            { 3756000.0d, 0.000187944d },
            { 3777000.0d, 0.00018606d },
            { 3798000.0d, 0.000184167d },
            { 3819000.0d, 0.000182267d },
            { 3840000.0d, 0.00018036d },
            { 3861000.0d, 0.000178444d },
            { 3882000.0d, 0.000176519d },
            { 3903000.0d, 0.000174582d },
            { 3924000.0d, 0.000172635d },
            { 3945000.0d, 0.000170679d },
            { 3966000.0d, 0.000168712d },
            { 3987000.0d, 0.000166736d },
            { 4008000.0d, 0.00016475d },
            { 4029000.0d, 0.000162755d },
            { 4050000.0d, 0.000160752d },
            { 4071000.0d, 0.000158741d },
            { 4092000.0d, 0.000156724d },
            { 4113000.0d, 0.000154701d },
            { 4134000.0d, 0.000152672d },
            { 4155000.0d, 0.00015064d },
            { 4176000.0d, 0.000148605d },
            { 4197000.0d, 0.000146566d },
            { 4218000.0d, 0.000144525d },
            { 4239000.0d, 0.00014248d },
            { 4260000.0d, 0.00014043d },
            { 4281000.0d, 0.000138374d },
            { 4302000.0d, 0.000136311d },
            { 4323000.0d, 0.000134244d },
            { 4344000.0d, 0.000132173d },
            { 4365000.0d, 0.000130096d },
            { 4386000.0d, 0.000128017d },
            { 4407000.0d, 0.000125935d },
            { 4428000.0d, 0.000123851d },
            { 4449000.0d, 0.000121766d },
            { 4470000.0d, 0.000119681d },
            { 4491000.0d, 0.000117596d },
            { 4512000.0d, 0.000115513d },
            { 4533000.0d, 0.00011343d },
            { 4554000.0d, 0.000111351d },
            { 4575000.0d, 0.000109275d },
            { 4596000.0d, 0.000107203d },
            { 4617000.0d, 0.000105135d },
            { 4638000.0d, 0.000103074d },
            { 4659000.0d, 0.000101018d },
            { 4680000.0d, 0.0000989704d },
            { 4701000.0d, 0.0000969304d },
            { 4722000.0d, 0.000094899d },
            { 4743000.0d, 0.0000928773d },
            { 4764000.0d, 0.000090866d },
            { 4785000.0d, 0.0000888659d },
            { 4806000.0d, 0.0000868778d },
            { 4827000.0d, 0.0000849025d },
            { 4848000.0d, 0.0000829408d },
            { 4869000.0d, 0.0000809938d },
            { 4890000.0d, 0.000079062d },
            { 4911000.0d, 0.0000771464d },
            { 4932000.0d, 0.0000752478d },
            { 4953000.0d, 0.0000733671d },
            { 4974000.0d, 0.0000715053d },
            { 4995000.0d, 0.000069663d },
            { 5016000.0d, 0.0000678411d },
            { 5037000.0d, 0.0000660406d },
            { 5058000.0d, 0.0000642624d },
            { 5079000.0d, 0.0000625071d },
            { 5100000.0d, 0.000060776d },
            { 5121000.0d, 0.0000590696d },
            { 5142000.0d, 0.000057389d },
            { 5163000.0d, 0.000055735d },
            { 5184000.0d, 0.0000541085d },
            { 5205000.0d, 0.0000525102d },
            { 5226000.0d, 0.0000509412d },
            { 5247000.0d, 0.0000493958d },
            { 5268000.0d, 0.0000478627d },
            { 5289000.0d, 0.0000463423d },
            { 5310000.0d, 0.0000448349d },
            { 5331000.0d, 0.0000433413d },
            { 5352000.0d, 0.000041862d },
            { 5373000.0d, 0.0000403977d },
            { 5394000.0d, 0.0000389489d },
            { 5415000.0d, 0.0000375162d },
            { 5436000.0d, 0.0000361001d },
            { 5457000.0d, 0.0000347014d },
            { 5478000.0d, 0.0000333207d },
            { 5499000.0d, 0.0000319584d },
            { 5520000.0d, 0.0000306154d },
            { 5541000.0d, 0.0000292921d },
            { 5562000.0d, 0.0000279892d },
            { 5583000.0d, 0.0000267074d },
            { 5604000.0d, 0.0000254472d },
            { 5625000.0d, 0.0000242092d },
            { 5646000.0d, 0.0000229943d },
            { 5667000.0d, 0.0000218029d },
            { 5688000.0d, 0.0000206356d },
            { 5709000.0d, 0.0000194932d },
            { 5730000.0d, 0.0000183763d },
            { 5751000.0d, 0.0000172855d },
            { 5772000.0d, 0.0000162215d },
            { 5793000.0d, 0.0000151849d },
            { 5814000.0d, 0.0000141765d },
            { 5835000.0d, 0.0000131968d },
            { 5856000.0d, 0.0000122465d },
            { 5877000.0d, 0.0000113262d },
            { 5898000.0d, 0.0000104367d },
            { 5919000.0d, 0.00000957866d },
            { 5940000.0d, 0.00000875266d },
            { 5961000.0d, 0.0000079594d },
            { 5982000.0d, 0.00000719956d },
            { 6003000.0d, 0.00000647382d },
            { 6024000.0d, 0.00000578285d },
            { 6045000.0d, 0.00000512732d },
            { 6066000.0d, 0.00000450791d },
            { 6087000.0d, 0.00000392532d },
            { 6108000.0d, 0.00000338019d },
            { 6129000.0d, 0.00000287322d },
            { 6150000.0d, 0.00000240509d },
            { 6171000.0d, 0.00000197647d },
            { 6192000.0d, 0.00000158803d },
            { 6213000.0d, 0.00000124043d },
            { 6234000.0d, 0.000000934349d },
            { 6255000.0d, 0.000000670438d },
            { 6276000.0d, 0.00000044934d },
            { 6297000.0d, 0.000000271683d },
            { 6318000.0d, 0.000000138069d },
            { 6339000.0d, 0.0000000490506d },
            { 6360000.0d, 0.00000000507046d },
            { 6370000.0d, 0d },

        }; 
    }
}
    