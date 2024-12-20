using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine72 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine72";
        public override double halfLife { get; } = 78.6d;
        public override double atomicWeight { get; } = 71.93659d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic72()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.026000000000000002d, new GammaParticle(75000.0, 0.01653)), new(0.035802d, new GammaParticle(379900.0, 0.00326)), new(0.035802d, new GammaParticle(379900.0, 0.00326)), new(0.131274d, new GammaParticle(454700.0, 0.00273)), new(0.020358d, new GammaParticle(512000.0, 0.00242)), new(0.012636000000000001d, new GammaParticle(537600.0, 0.00231)), new(0.025974d, new GammaParticle(559300.0, 0.00222)), new(0.016146d, new GammaParticle(710200.0, 0.00175)), new(0.029484d, new GammaParticle(752800.0, 0.00165)), new(0.070902d, new GammaParticle(774800.0, 0.0016)), new(0.020358d, new GammaParticle(832000.0, 0.00149)), new(0.7020000000000001d, new GammaParticle(862000.0, 0.00144)), new(0.007019999999999999d, new GammaParticle(1014000.0, 0.00122)), new(0.037206d, new GammaParticle(1054700.0, 0.00118)), new(0.055458d, new GammaParticle(1061600.0, 0.00117)), new(0.03159d, new GammaParticle(1089200.0, 0.00114)), new(0.03159d, new GammaParticle(1089200.0, 0.00114)), new(0.053352000000000004d, new GammaParticle(1125100.0, 0.0011)), new(0.0702d, new GammaParticle(1136400.0, 0.00109)), new(0.01053d, new GammaParticle(1227300.0, 0.00101)), new(0.008424000000000001d, new GammaParticle(1269500.0, 0.00098)), new(0.172692d, new GammaParticle(1316700.0, 0.00094)), new(0.022463999999999998d, new GammaParticle(1349900.0, 0.00092)), new(0.009828d, new GammaParticle(1433600.0, 0.00086)), new(0.032993999999999996d, new GammaParticle(1509800.0, 0.00082)), new(0.037908d, new GammaParticle(1571300.0, 0.00079)), new(0.015444d, new GammaParticle(1648500.0, 0.00075)), new(0.034398d, new GammaParticle(1724000.0, 0.00072)), new(0.01755d, new GammaParticle(1807400.0, 0.00069)), new(0.013338000000000001d, new GammaParticle(1909400.0, 0.00065)), new(0.009828d, new GammaParticle(2150700.0, 0.00058)), new(0.075114d, new GammaParticle(2371900.0, 0.00052)), new(0.012636000000000001d, new GammaParticle(2432700.0, 0.00051)), new(0.009828d, new GammaParticle(2465000.0, 0.0005)), new(2.02d, new GammaParticle(511000.0, 0.00243)), new(0.0014000000000000002d, new GammaParticle(1426.0, 0.86945)), new(0.01d, new GammaParticle(11183.0, 0.11087)), new(0.02d, new GammaParticle(11223.0, 0.11047)), new(0.004699999999999999d, new GammaParticle(12546.0, 0.09882)), new(0.005d, new GammaParticle(12571.0, 0.09863)), new(0.00026d, new GammaParticle(12652.0, 0.098)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 15000.0d, 0.000000567844d },
            { 30000.0d, 0.00000217229d },
            { 45000.0d, 0.00000448155d },
            { 60000.0d, 0.00000706674d },
            { 75000.0d, 0.00000979753d },
            { 90000.0d, 0.0000125975d },
            { 105000.0d, 0.0000154302d },
            { 120000.0d, 0.0000182773d },
            { 135000.0d, 0.0000211277d },
            { 150000.0d, 0.0000239758d },
            { 165000.0d, 0.000026818d },
            { 180000.0d, 0.0000296526d },
            { 195000.0d, 0.0000324788d },
            { 210000.0d, 0.0000352962d },
            { 225000.0d, 0.0000381047d },
            { 240000.0d, 0.0000409043d },
            { 255000.0d, 0.0000436952d },
            { 270000.0d, 0.0000464776d },
            { 285000.0d, 0.0000492515d },
            { 300000.0d, 0.0000520172d },
            { 315000.0d, 0.0000547747d },
            { 330000.0d, 0.0000575241d },
            { 345000.0d, 0.0000602654d },
            { 360000.0d, 0.0000629987d },
            { 375000.0d, 0.0000657239d },
            { 390000.0d, 0.000068441d },
            { 405000.0d, 0.00007115d },
            { 420000.0d, 0.0000738506d },
            { 435000.0d, 0.0000765427d },
            { 450000.0d, 0.0000792264d },
            { 465000.0d, 0.0000819015d },
            { 480000.0d, 0.0000845676d },
            { 495000.0d, 0.0000872248d },
            { 510000.0d, 0.0000898729d },
            { 525000.0d, 0.0000925115d },
            { 540000.0d, 0.0000951407d },
            { 555000.0d, 0.0000977602d },
            { 570000.0d, 0.00010037d },
            { 585000.0d, 0.000102969d },
            { 600000.0d, 0.000105558d },
            { 615000.0d, 0.000108136d },
            { 630000.0d, 0.000110704d },
            { 645000.0d, 0.00011326d },
            { 660000.0d, 0.000115805d },
            { 675000.0d, 0.000118339d },
            { 690000.0d, 0.000120861d },
            { 705000.0d, 0.000123371d },
            { 720000.0d, 0.00012587d },
            { 735000.0d, 0.000128355d },
            { 750000.0d, 0.000130829d },
            { 765000.0d, 0.000133289d },
            { 780000.0d, 0.000135737d },
            { 795000.0d, 0.000138171d },
            { 810000.0d, 0.000140592d },
            { 825000.0d, 0.000142999d },
            { 840000.0d, 0.000145393d },
            { 855000.0d, 0.000147772d },
            { 870000.0d, 0.000150137d },
            { 885000.0d, 0.000152488d },
            { 900000.0d, 0.000154825d },
            { 915000.0d, 0.000157146d },
            { 930000.0d, 0.000159452d },
            { 945000.0d, 0.000161744d },
            { 960000.0d, 0.00016402d },
            { 975000.0d, 0.00016628d },
            { 990000.0d, 0.000168524d },
            { 1005000.0d, 0.000170753d },
            { 1028000.0d, 0.000174138d },
            { 1051000.0d, 0.000177485d },
            { 1074000.0d, 0.000180792d },
            { 1097000.0d, 0.00018406d },
            { 1120000.0d, 0.000187287d },
            { 1143000.0d, 0.000190473d },
            { 1166000.0d, 0.000193617d },
            { 1189000.0d, 0.000196718d },
            { 1212000.0d, 0.000199777d },
            { 1235000.0d, 0.000202792d },
            { 1258000.0d, 0.000205763d },
            { 1281000.0d, 0.000208689d },
            { 1304000.0d, 0.00021157d },
            { 1327000.0d, 0.000214405d },
            { 1350000.0d, 0.000217193d },
            { 1373000.0d, 0.000219935d },
            { 1396000.0d, 0.00022263d },
            { 1419000.0d, 0.000225277d },
            { 1442000.0d, 0.000227875d },
            { 1465000.0d, 0.000230424d },
            { 1488000.0d, 0.000232925d },
            { 1511000.0d, 0.000235375d },
            { 1534000.0d, 0.000237776d },
            { 1557000.0d, 0.000240125d },
            { 1580000.0d, 0.000242424d },
            { 1603000.0d, 0.000244671d },
            { 1626000.0d, 0.000246866d },
            { 1649000.0d, 0.000249009d },
            { 1672000.0d, 0.0002511d },
            { 1695000.0d, 0.000253137d },
            { 1718000.0d, 0.000255121d },
            { 1741000.0d, 0.000257051d },
            { 1764000.0d, 0.000258928d },
            { 1787000.0d, 0.00026075d },
            { 1810000.0d, 0.000262517d },
            { 1833000.0d, 0.000264229d },
            { 1856000.0d, 0.000265886d },
            { 1879000.0d, 0.000267487d },
            { 1902000.0d, 0.000269033d },
            { 1925000.0d, 0.000270523d },
            { 1948000.0d, 0.000271956d },
            { 1971000.0d, 0.000273333d },
            { 1994000.0d, 0.000274654d },
            { 2017000.0d, 0.000275917d },
            { 2040000.0d, 0.000277124d },
            { 2063000.0d, 0.000278273d },
            { 2086000.0d, 0.000279365d },
            { 2109000.0d, 0.000280399d },
            { 2132000.0d, 0.000281376d },
            { 2155000.0d, 0.000282295d },
            { 2178000.0d, 0.000283157d },
            { 2201000.0d, 0.00028396d },
            { 2224000.0d, 0.000284706d },
            { 2247000.0d, 0.000285393d },
            { 2270000.0d, 0.000286022d },
            { 2293000.0d, 0.000286593d },
            { 2316000.0d, 0.000287107d },
            { 2339000.0d, 0.000287561d },
            { 2362000.0d, 0.000287958d },
            { 2385000.0d, 0.000288297d },
            { 2408000.0d, 0.000288578d },
            { 2431000.0d, 0.000288801d },
            { 2454000.0d, 0.000288966d },
            { 2477000.0d, 0.000289073d },
            { 2500000.0d, 0.000289122d },
            { 2523000.0d, 0.000289113d },
            { 2546000.0d, 0.000289047d },
            { 2569000.0d, 0.000288924d },
            { 2592000.0d, 0.000288743d },
            { 2615000.0d, 0.000288505d },
            { 2638000.0d, 0.00028821d },
            { 2661000.0d, 0.000287858d },
            { 2684000.0d, 0.000287449d },
            { 2707000.0d, 0.000286984d },
            { 2730000.0d, 0.000286462d },
            { 2753000.0d, 0.000285885d },
            { 2776000.0d, 0.000285251d },
            { 2799000.0d, 0.000284563d },
            { 2822000.0d, 0.000283818d },
            { 2845000.0d, 0.000283019d },
            { 2868000.0d, 0.000282164d },
            { 2891000.0d, 0.000281255d },
            { 2914000.0d, 0.000280292d },
            { 2937000.0d, 0.000279275d },
            { 2960000.0d, 0.000278204d },
            { 2983000.0d, 0.00027708d },
            { 3006000.0d, 0.000275903d },
            { 3029000.0d, 0.000274673d },
            { 3052000.0d, 0.000273391d },
            { 3075000.0d, 0.000272056d },
            { 3098000.0d, 0.000270671d },
            { 3121000.0d, 0.000269233d },
            { 3144000.0d, 0.000267746d },
            { 3167000.0d, 0.000266207d },
            { 3190000.0d, 0.000264619d },
            { 3213000.0d, 0.000262982d },
            { 3236000.0d, 0.000261295d },
            { 3259000.0d, 0.00025956d },
            { 3282000.0d, 0.000257776d },
            { 3305000.0d, 0.000255945d },
            { 3328000.0d, 0.000254067d },
            { 3351000.0d, 0.000252142d },
            { 3374000.0d, 0.000250172d },
            { 3397000.0d, 0.000248156d },
            { 3420000.0d, 0.000246095d },
            { 3443000.0d, 0.00024399d },
            { 3466000.0d, 0.000241841d },
            { 3489000.0d, 0.00023965d },
            { 3512000.0d, 0.000237416d },
            { 3535000.0d, 0.000235141d },
            { 3558000.0d, 0.000232825d },
            { 3581000.0d, 0.000230469d },
            { 3604000.0d, 0.000228074d },
            { 3627000.0d, 0.000225641d },
            { 3650000.0d, 0.00022317d },
            { 3673000.0d, 0.000220663d },
            { 3696000.0d, 0.000218121d },
            { 3719000.0d, 0.000215543d },
            { 3742000.0d, 0.000212933d },
            { 3765000.0d, 0.00021029d },
            { 3788000.0d, 0.000207615d },
            { 3811000.0d, 0.000204911d },
            { 3834000.0d, 0.000202178d },
            { 3857000.0d, 0.000199417d },
            { 3880000.0d, 0.00019663d },
            { 3903000.0d, 0.000193819d },
            { 3926000.0d, 0.000190984d },
            { 3949000.0d, 0.000188128d },
            { 3972000.0d, 0.000185252d },
            { 3995000.0d, 0.000182358d },
            { 4018000.0d, 0.000179447d },
            { 4041000.0d, 0.000176522d },
            { 4064000.0d, 0.000173585d },
            { 4087000.0d, 0.000170638d },
            { 4110000.0d, 0.000167682d },
            { 4133000.0d, 0.000164721d },
            { 4156000.0d, 0.000161756d },
            { 4179000.0d, 0.00015879d },
            { 4202000.0d, 0.000155827d },
            { 4225000.0d, 0.000152868d },
            { 4248000.0d, 0.000149917d },
            { 4271000.0d, 0.000146977d },
            { 4294000.0d, 0.00014405d },
            { 4317000.0d, 0.000141141d },
            { 4340000.0d, 0.000138253d },
            { 4363000.0d, 0.00013539d },
            { 4386000.0d, 0.000132555d },
            { 4409000.0d, 0.000129753d },
            { 4432000.0d, 0.000126988d },
            { 4455000.0d, 0.000124264d },
            { 4478000.0d, 0.000121587d },
            { 4501000.0d, 0.00011896d },
            { 4524000.0d, 0.000116388d },
            { 4547000.0d, 0.000113878d },
            { 4570000.0d, 0.000111424d },
            { 4593000.0d, 0.000109022d },
            { 4616000.0d, 0.00010668d },
            { 4639000.0d, 0.000104402d },
            { 4662000.0d, 0.000102188d },
            { 4685000.0d, 0.0000999978d },
            { 4708000.0d, 0.0000978206d },
            { 4731000.0d, 0.0000956582d },
            { 4754000.0d, 0.000093512d },
            { 4777000.0d, 0.0000913836d },
            { 4800000.0d, 0.0000892746d },
            { 4823000.0d, 0.0000871851d },
            { 4846000.0d, 0.0000851093d },
            { 4869000.0d, 0.0000830474d },
            { 4892000.0d, 0.0000810009d },
            { 4915000.0d, 0.0000789714d },
            { 4938000.0d, 0.0000769604d },
            { 4961000.0d, 0.0000749694d },
            { 4984000.0d, 0.0000730001d },
            { 5007000.0d, 0.0000710541d },
            { 5030000.0d, 0.0000691329d },
            { 5053000.0d, 0.0000672385d },
            { 5076000.0d, 0.0000653726d },
            { 5099000.0d, 0.0000635367d },
            { 5122000.0d, 0.0000617328d },
            { 5145000.0d, 0.0000599627d },
            { 5168000.0d, 0.0000582283d },
            { 5191000.0d, 0.0000565313d },
            { 5214000.0d, 0.0000548699d },
            { 5237000.0d, 0.0000532415d },
            { 5260000.0d, 0.000051648d },
            { 5283000.0d, 0.000050091d },
            { 5306000.0d, 0.0000485722d },
            { 5329000.0d, 0.0000470931d },
            { 5352000.0d, 0.0000456547d },
            { 5375000.0d, 0.0000442488d },
            { 5398000.0d, 0.0000428736d },
            { 5421000.0d, 0.0000415261d },
            { 5444000.0d, 0.0000401941d },
            { 5467000.0d, 0.000038877d },
            { 5490000.0d, 0.000037576d },
            { 5513000.0d, 0.0000362917d },
            { 5536000.0d, 0.0000350252d },
            { 5559000.0d, 0.0000337772d },
            { 5582000.0d, 0.0000325487d },
            { 5605000.0d, 0.0000313408d },
            { 5628000.0d, 0.0000301542d },
            { 5651000.0d, 0.0000289879d },
            { 5674000.0d, 0.0000278411d },
            { 5697000.0d, 0.0000267147d },
            { 5720000.0d, 0.0000256097d },
            { 5743000.0d, 0.000024527d },
            { 5766000.0d, 0.0000234676d },
            { 5789000.0d, 0.0000224317d },
            { 5812000.0d, 0.0000214144d },
            { 5835000.0d, 0.0000204157d },
            { 5858000.0d, 0.0000194365d },
            { 5881000.0d, 0.0000184779d },
            { 5904000.0d, 0.0000175408d },
            { 5927000.0d, 0.0000166262d },
            { 5950000.0d, 0.0000157352d },
            { 5973000.0d, 0.000014869d },
            { 5996000.0d, 0.0000140285d },
            { 6019000.0d, 0.000013215d },
            { 6042000.0d, 0.0000124296d },
            { 6065000.0d, 0.0000116734d },
            { 6088000.0d, 0.0000109478d },
            { 6111000.0d, 0.0000102539d },
            { 6134000.0d, 0.00000959294d },
            { 6157000.0d, 0.00000896251d },
            { 6180000.0d, 0.00000835457d },
            { 6203000.0d, 0.00000776926d },
            { 6226000.0d, 0.00000720713d },
            { 6249000.0d, 0.00000666875d },
            { 6272000.0d, 0.00000615469d },
            { 6295000.0d, 0.00000566553d },
            { 6318000.0d, 0.00000520183d },
            { 6341000.0d, 0.00000476417d },
            { 6364000.0d, 0.00000435312d },
            { 6387000.0d, 0.00000396925d },
            { 6410000.0d, 0.0000036131d },
            { 6433000.0d, 0.0000032852d },
            { 6456000.0d, 0.00000298602d },
            { 6479000.0d, 0.00000270985d },
            { 6502000.0d, 0.00000244563d },
            { 6525000.0d, 0.00000219337d },
            { 6548000.0d, 0.00000195336d },
            { 6571000.0d, 0.00000172586d },
            { 6594000.0d, 0.00000151113d },
            { 6617000.0d, 0.00000130947d },
            { 6640000.0d, 0.00000112114d },
            { 6663000.0d, 0.000000946409d },
            { 6686000.0d, 0.000000785563d },
            { 6709000.0d, 0.000000638877d },
            { 6732000.0d, 0.000000506623d },
            { 6755000.0d, 0.000000389075d },
            { 6778000.0d, 0.000000286504d },
            { 6801000.0d, 0.000000199178d },
            { 6824000.0d, 0.000000127363d },
            { 6847000.0d, 0.0000000713131d },
            { 6870000.0d, 0.0000000312744d },
            { 6893000.0d, 0.00000000746296d },
            { 6915000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    