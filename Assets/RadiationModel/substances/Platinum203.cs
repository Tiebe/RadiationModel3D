using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum203 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum203";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 202.97906d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold203()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.02943d, new GammaParticle(39000.0, 0.03179)), new(0.03597d, new GammaParticle(311000.0, 0.00399)), new(0.071395d, new GammaParticle(353000.0, 0.00351)), new(0.09483000000000001d, new GammaParticle(385000.0, 0.00322)), new(0.046325000000000005d, new GammaParticle(563000.0, 0.0022)), new(0.022345d, new GammaParticle(776000.0, 0.0016)), new(0.036515d, new GammaParticle(889000.0, 0.00139)), new(0.545d, new GammaParticle(943600.0, 0.00131)), new(0.033245d, new GammaParticle(976800.0, 0.00127)), new(0.085565d, new GammaParticle(1505800.0, 0.00082)), new(0.17d, new GammaParticle(11419.0, 0.10858)), new(0.0077d, new GammaParticle(66991.0, 0.01851)), new(0.0131d, new GammaParticle(68806.0, 0.01802)), new(0.0044d, new GammaParticle(78048.0, 0.01589)), new(0.005699999999999999d, new GammaParticle(78983.0, 0.0157)), new(0.00128d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000264793d },
            { 7000.0d, 0.000270373d },
            { 14000.0d, 0.000275513d },
            { 21000.0d, 0.000280213d },
            { 28000.0d, 0.000284646d },
            { 35000.0d, 0.000288992d },
            { 42000.0d, 0.000293283d },
            { 49000.0d, 0.00029753d },
            { 56000.0d, 0.000301742d },
            { 63000.0d, 0.000305923d },
            { 70000.0d, 0.000310078d },
            { 77000.0d, 0.00031421d },
            { 84000.0d, 0.000318319d },
            { 91000.0d, 0.000322408d },
            { 98000.0d, 0.000326478d },
            { 105000.0d, 0.000330528d },
            { 115000.0d, 0.000336282d },
            { 125000.0d, 0.000341998d },
            { 135000.0d, 0.000347674d },
            { 145000.0d, 0.000353311d },
            { 155000.0d, 0.000358906d },
            { 165000.0d, 0.000364457d },
            { 175000.0d, 0.000369965d },
            { 185000.0d, 0.000375425d },
            { 195000.0d, 0.000380838d },
            { 205000.0d, 0.000386201d },
            { 215000.0d, 0.000391513d },
            { 225000.0d, 0.000396772d },
            { 235000.0d, 0.000401975d },
            { 245000.0d, 0.000407122d },
            { 255000.0d, 0.000412212d },
            { 265000.0d, 0.000417242d },
            { 275000.0d, 0.000422212d },
            { 285000.0d, 0.000427119d },
            { 295000.0d, 0.000431963d },
            { 305000.0d, 0.000436742d },
            { 315000.0d, 0.000441455d },
            { 325000.0d, 0.000446101d },
            { 335000.0d, 0.000450679d },
            { 345000.0d, 0.000455188d },
            { 355000.0d, 0.000459626d },
            { 365000.0d, 0.000463992d },
            { 375000.0d, 0.000468287d },
            { 385000.0d, 0.000472508d },
            { 395000.0d, 0.000476654d },
            { 405000.0d, 0.000480726d },
            { 415000.0d, 0.000484722d },
            { 425000.0d, 0.000488641d },
            { 435000.0d, 0.000492483d },
            { 445000.0d, 0.000496247d },
            { 455000.0d, 0.000499932d },
            { 465000.0d, 0.000503538d },
            { 475000.0d, 0.000507064d },
            { 485000.0d, 0.000510509d },
            { 495000.0d, 0.000513873d },
            { 505000.0d, 0.000517155d },
            { 515000.0d, 0.000520357d },
            { 525000.0d, 0.000523474d },
            { 535000.0d, 0.000526509d },
            { 545000.0d, 0.00052946d },
            { 555000.0d, 0.000532328d },
            { 565000.0d, 0.000535112d },
            { 575000.0d, 0.00053781d },
            { 585000.0d, 0.000540424d },
            { 595000.0d, 0.000542954d },
            { 605000.0d, 0.000545397d },
            { 615000.0d, 0.000547756d },
            { 625000.0d, 0.000550028d },
            { 635000.0d, 0.000552215d },
            { 645000.0d, 0.000554315d },
            { 655000.0d, 0.000556329d },
            { 665000.0d, 0.000558257d },
            { 675000.0d, 0.000560097d },
            { 685000.0d, 0.000561852d },
            { 695000.0d, 0.000563521d },
            { 705000.0d, 0.000565101d },
            { 715000.0d, 0.000566596d },
            { 725000.0d, 0.000568004d },
            { 735000.0d, 0.000569325d },
            { 745000.0d, 0.00057056d },
            { 755000.0d, 0.000571707d },
            { 765000.0d, 0.00057277d },
            { 775000.0d, 0.000573745d },
            { 785000.0d, 0.000574634d },
            { 795000.0d, 0.000575436d },
            { 805000.0d, 0.000576154d },
            { 815000.0d, 0.000576784d },
            { 825000.0d, 0.00057733d },
            { 835000.0d, 0.00057779d },
            { 845000.0d, 0.000578165d },
            { 855000.0d, 0.000578455d },
            { 865000.0d, 0.00057866d },
            { 875000.0d, 0.000578781d },
            { 885000.0d, 0.000578818d },
            { 895000.0d, 0.000578772d },
            { 905000.0d, 0.000578642d },
            { 915000.0d, 0.000578428d },
            { 925000.0d, 0.000578132d },
            { 935000.0d, 0.000577753d },
            { 945000.0d, 0.000577293d },
            { 955000.0d, 0.000576751d },
            { 965000.0d, 0.000576128d },
            { 975000.0d, 0.000575424d },
            { 985000.0d, 0.000574641d },
            { 995000.0d, 0.000573777d },
            { 1005000.0d, 0.000572834d },
            { 1017000.0d, 0.000571598d },
            { 1029000.0d, 0.00057025d },
            { 1041000.0d, 0.00056879d },
            { 1053000.0d, 0.00056722d },
            { 1065000.0d, 0.00056554d },
            { 1077000.0d, 0.000563752d },
            { 1089000.0d, 0.000561855d },
            { 1101000.0d, 0.000559852d },
            { 1113000.0d, 0.000557744d },
            { 1125000.0d, 0.000555531d },
            { 1137000.0d, 0.000553216d },
            { 1149000.0d, 0.000550798d },
            { 1161000.0d, 0.000548279d },
            { 1173000.0d, 0.000545662d },
            { 1185000.0d, 0.000542945d },
            { 1197000.0d, 0.000540132d },
            { 1209000.0d, 0.000537224d },
            { 1221000.0d, 0.000534221d },
            { 1233000.0d, 0.000531124d },
            { 1245000.0d, 0.000527937d },
            { 1257000.0d, 0.000524659d },
            { 1269000.0d, 0.000521293d },
            { 1281000.0d, 0.00051784d },
            { 1293000.0d, 0.000514301d },
            { 1305000.0d, 0.000510678d },
            { 1317000.0d, 0.000506972d },
            { 1329000.0d, 0.000503186d },
            { 1341000.0d, 0.00049932d },
            { 1353000.0d, 0.000495376d },
            { 1365000.0d, 0.000491357d },
            { 1377000.0d, 0.000487262d },
            { 1389000.0d, 0.000483095d },
            { 1401000.0d, 0.000478858d },
            { 1413000.0d, 0.00047455d },
            { 1425000.0d, 0.000470176d },
            { 1437000.0d, 0.000465735d },
            { 1449000.0d, 0.000461231d },
            { 1461000.0d, 0.000456664d },
            { 1473000.0d, 0.000452038d },
            { 1485000.0d, 0.000447354d },
            { 1497000.0d, 0.000442612d },
            { 1509000.0d, 0.000437816d },
            { 1521000.0d, 0.000432968d },
            { 1533000.0d, 0.000428069d },
            { 1545000.0d, 0.000423121d },
            { 1557000.0d, 0.000418128d },
            { 1569000.0d, 0.000413089d },
            { 1581000.0d, 0.000408008d },
            { 1593000.0d, 0.000402887d },
            { 1605000.0d, 0.000397727d },
            { 1617000.0d, 0.00039253d },
            { 1629000.0d, 0.000387301d },
            { 1641000.0d, 0.000382038d },
            { 1653000.0d, 0.000376747d },
            { 1665000.0d, 0.000371427d },
            { 1677000.0d, 0.000366083d },
            { 1689000.0d, 0.000360714d },
            { 1701000.0d, 0.000355326d },
            { 1713000.0d, 0.000349918d },
            { 1725000.0d, 0.000344494d },
            { 1737000.0d, 0.000339056d },
            { 1749000.0d, 0.000333607d },
            { 1761000.0d, 0.000328147d },
            { 1773000.0d, 0.000322681d },
            { 1785000.0d, 0.000317211d },
            { 1797000.0d, 0.000311737d },
            { 1809000.0d, 0.000306264d },
            { 1821000.0d, 0.000300794d },
            { 1833000.0d, 0.000295328d },
            { 1845000.0d, 0.00028987d },
            { 1857000.0d, 0.000284422d },
            { 1869000.0d, 0.000278986d },
            { 1881000.0d, 0.000273566d },
            { 1893000.0d, 0.000268162d },
            { 1905000.0d, 0.000262779d },
            { 1917000.0d, 0.000257418d },
            { 1929000.0d, 0.000252082d },
            { 1941000.0d, 0.000246774d },
            { 1953000.0d, 0.000241496d },
            { 1965000.0d, 0.000236251d },
            { 1977000.0d, 0.000231042d },
            { 1989000.0d, 0.00022587d },
            { 2001000.0d, 0.00022074d },
            { 2013000.0d, 0.000215653d },
            { 2025000.0d, 0.000210612d },
            { 2037000.0d, 0.00020562d },
            { 2049000.0d, 0.00020068d },
            { 2061000.0d, 0.000195794d },
            { 2073000.0d, 0.000190964d },
            { 2085000.0d, 0.000186195d },
            { 2097000.0d, 0.000181488d },
            { 2109000.0d, 0.000176846d },
            { 2121000.0d, 0.000172272d },
            { 2133000.0d, 0.00016776d },
            { 2145000.0d, 0.000163292d },
            { 2157000.0d, 0.000158868d },
            { 2169000.0d, 0.00015449d },
            { 2181000.0d, 0.000150162d },
            { 2193000.0d, 0.000145884d },
            { 2205000.0d, 0.00014166d },
            { 2217000.0d, 0.000137492d },
            { 2229000.0d, 0.000133381d },
            { 2241000.0d, 0.000129331d },
            { 2253000.0d, 0.000125343d },
            { 2265000.0d, 0.000121419d },
            { 2277000.0d, 0.000117563d },
            { 2289000.0d, 0.000113776d },
            { 2301000.0d, 0.00011006d },
            { 2313000.0d, 0.000106419d },
            { 2325000.0d, 0.000102853d },
            { 2337000.0d, 0.0000993667d },
            { 2349000.0d, 0.0000959608d },
            { 2361000.0d, 0.0000926375d },
            { 2373000.0d, 0.0000893913d },
            { 2385000.0d, 0.0000862227d },
            { 2397000.0d, 0.0000831343d },
            { 2409000.0d, 0.0000801278d },
            { 2421000.0d, 0.0000772058d },
            { 2433000.0d, 0.0000743704d },
            { 2445000.0d, 0.0000716238d },
            { 2457000.0d, 0.0000689683d },
            { 2469000.0d, 0.0000664061d },
            { 2481000.0d, 0.0000639365d },
            { 2493000.0d, 0.0000615594d },
            { 2505000.0d, 0.0000592764d },
            { 2517000.0d, 0.0000570901d },
            { 2529000.0d, 0.0000550026d },
            { 2541000.0d, 0.000053016d },
            { 2553000.0d, 0.0000511326d },
            { 2565000.0d, 0.0000493545d },
            { 2577000.0d, 0.0000476838d },
            { 2589000.0d, 0.0000461229d },
            { 2601000.0d, 0.0000446737d },
            { 2613000.0d, 0.0000433384d },
            { 2625000.0d, 0.0000421193d },
            { 2637000.0d, 0.000041018d },
            { 2649000.0d, 0.0000400354d },
            { 2661000.0d, 0.0000391043d },
            { 2673000.0d, 0.00003818d },
            { 2685000.0d, 0.0000372626d },
            { 2697000.0d, 0.0000363525d },
            { 2709000.0d, 0.0000354498d },
            { 2721000.0d, 0.0000345552d },
            { 2733000.0d, 0.0000336688d },
            { 2745000.0d, 0.0000327912d },
            { 2757000.0d, 0.0000319226d },
            { 2769000.0d, 0.0000310615d },
            { 2781000.0d, 0.0000302067d },
            { 2793000.0d, 0.0000293586d },
            { 2805000.0d, 0.0000285176d },
            { 2817000.0d, 0.0000276842d },
            { 2829000.0d, 0.0000268586d },
            { 2841000.0d, 0.0000260413d },
            { 2853000.0d, 0.0000252328d },
            { 2865000.0d, 0.0000244334d },
            { 2877000.0d, 0.0000236437d },
            { 2889000.0d, 0.0000228641d },
            { 2901000.0d, 0.0000220951d },
            { 2913000.0d, 0.0000213371d },
            { 2925000.0d, 0.0000205907d },
            { 2937000.0d, 0.0000198564d },
            { 2949000.0d, 0.0000191347d },
            { 2961000.0d, 0.0000184261d },
            { 2973000.0d, 0.0000177312d },
            { 2985000.0d, 0.0000170506d },
            { 2997000.0d, 0.0000163849d },
            { 3009000.0d, 0.0000157346d },
            { 3021000.0d, 0.0000151004d },
            { 3033000.0d, 0.0000144829d },
            { 3045000.0d, 0.0000138827d },
            { 3057000.0d, 0.0000133005d },
            { 3069000.0d, 0.0000127369d },
            { 3081000.0d, 0.0000121873d },
            { 3093000.0d, 0.0000116493d },
            { 3105000.0d, 0.0000111232d },
            { 3117000.0d, 0.0000106093d },
            { 3129000.0d, 0.0000101077d },
            { 3141000.0d, 0.00000961873d },
            { 3153000.0d, 0.00000914265d },
            { 3165000.0d, 0.0000086797d },
            { 3177000.0d, 0.00000823012d },
            { 3189000.0d, 0.00000779416d },
            { 3201000.0d, 0.00000737206d },
            { 3213000.0d, 0.0000069641d },
            { 3225000.0d, 0.00000657048d },
            { 3237000.0d, 0.00000619143d },
            { 3249000.0d, 0.00000582689d },
            { 3261000.0d, 0.00000547284d },
            { 3273000.0d, 0.00000512821d },
            { 3285000.0d, 0.00000479318d },
            { 3297000.0d, 0.00000446794d },
            { 3309000.0d, 0.00000415264d },
            { 3321000.0d, 0.00000384747d },
            { 3333000.0d, 0.00000355259d },
            { 3345000.0d, 0.0000032682d },
            { 3357000.0d, 0.00000299447d },
            { 3369000.0d, 0.00000273156d },
            { 3381000.0d, 0.00000247967d },
            { 3393000.0d, 0.00000223896d },
            { 3405000.0d, 0.00000200962d },
            { 3417000.0d, 0.00000179182d },
            { 3429000.0d, 0.00000158573d },
            { 3441000.0d, 0.00000139155d },
            { 3453000.0d, 0.00000120943d },
            { 3465000.0d, 0.00000103957d },
            { 3477000.0d, 0.000000882126d },
            { 3489000.0d, 0.000000737286d },
            { 3501000.0d, 0.00000060522d },
            { 3513000.0d, 0.000000486102d },
            { 3525000.0d, 0.000000380104d },
            { 3537000.0d, 0.000000287395d },
            { 3549000.0d, 0.000000208143d },
            { 3561000.0d, 0.000000142511d },
            { 3573000.0d, 0.0000000906545d },
            { 3585000.0d, 0.0000000527162d },
            { 3597000.0d, 0.000000027943d },
            { 3609000.0d, 0.0000000113213d },
            { 3621000.0d, 0.0000000020743d },
            { 3630000.0d, 0d },

        }; 
    }
}
    