using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt71 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt71";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 70.95237d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel71()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel71()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000710486d },
            { 10000.0d, 0.00000743021d },
            { 20000.0d, 0.00000776563d },
            { 30000.0d, 0.00000811111d },
            { 40000.0d, 0.00000846666d },
            { 50000.0d, 0.00000883228d },
            { 60000.0d, 0.00000920796d },
            { 70000.0d, 0.00000959327d },
            { 80000.0d, 0.00000998627d },
            { 90000.0d, 0.0000103861d },
            { 100000.0d, 0.000010791d },
            { 110000.0d, 0.0000111988d },
            { 120000.0d, 0.0000116111d },
            { 130000.0d, 0.0000120274d },
            { 140000.0d, 0.0000124474d },
            { 150000.0d, 0.0000128712d },
            { 160000.0d, 0.0000132987d },
            { 170000.0d, 0.0000137298d },
            { 180000.0d, 0.0000141646d },
            { 190000.0d, 0.000014603d },
            { 200000.0d, 0.000015045d },
            { 210000.0d, 0.0000154905d },
            { 220000.0d, 0.0000159396d },
            { 230000.0d, 0.0000163923d },
            { 240000.0d, 0.0000168484d },
            { 250000.0d, 0.000017308d },
            { 260000.0d, 0.000017771d },
            { 270000.0d, 0.0000182375d },
            { 280000.0d, 0.0000187073d },
            { 290000.0d, 0.0000191806d },
            { 300000.0d, 0.0000196572d },
            { 310000.0d, 0.0000201371d },
            { 320000.0d, 0.0000206204d },
            { 330000.0d, 0.0000211068d },
            { 340000.0d, 0.0000215965d },
            { 350000.0d, 0.0000220894d },
            { 360000.0d, 0.0000225855d },
            { 370000.0d, 0.0000230847d },
            { 380000.0d, 0.0000235871d },
            { 390000.0d, 0.0000240925d },
            { 400000.0d, 0.0000246009d },
            { 410000.0d, 0.0000251124d },
            { 420000.0d, 0.0000256268d },
            { 430000.0d, 0.0000261442d },
            { 440000.0d, 0.0000266645d },
            { 450000.0d, 0.0000271877d },
            { 460000.0d, 0.0000277137d },
            { 470000.0d, 0.0000282425d },
            { 480000.0d, 0.0000287741d },
            { 490000.0d, 0.0000293084d },
            { 500000.0d, 0.0000298454d },
            { 510000.0d, 0.0000303851d },
            { 520000.0d, 0.0000309274d },
            { 530000.0d, 0.0000314723d },
            { 540000.0d, 0.0000320197d },
            { 550000.0d, 0.0000325697d },
            { 560000.0d, 0.0000331222d },
            { 570000.0d, 0.0000336771d },
            { 580000.0d, 0.0000342345d },
            { 590000.0d, 0.0000347942d },
            { 600000.0d, 0.0000353563d },
            { 610000.0d, 0.0000359207d },
            { 620000.0d, 0.0000364874d },
            { 630000.0d, 0.0000370563d },
            { 640000.0d, 0.0000376274d },
            { 650000.0d, 0.0000382007d },
            { 660000.0d, 0.0000387762d },
            { 670000.0d, 0.0000393537d },
            { 680000.0d, 0.0000399333d },
            { 690000.0d, 0.0000405149d },
            { 700000.0d, 0.0000410985d },
            { 710000.0d, 0.0000416841d },
            { 720000.0d, 0.0000422716d },
            { 730000.0d, 0.000042861d },
            { 740000.0d, 0.0000434523d },
            { 750000.0d, 0.0000440454d },
            { 760000.0d, 0.0000446403d },
            { 770000.0d, 0.0000452369d },
            { 780000.0d, 0.0000458352d },
            { 790000.0d, 0.0000464352d },
            { 800000.0d, 0.0000470369d },
            { 810000.0d, 0.0000476402d },
            { 820000.0d, 0.0000482451d },
            { 830000.0d, 0.0000488515d },
            { 840000.0d, 0.0000494595d },
            { 850000.0d, 0.0000500689d },
            { 860000.0d, 0.0000506798d },
            { 870000.0d, 0.0000512921d },
            { 880000.0d, 0.0000519057d },
            { 890000.0d, 0.0000525208d },
            { 900000.0d, 0.0000531371d },
            { 910000.0d, 0.0000537547d },
            { 920000.0d, 0.0000543736d },
            { 930000.0d, 0.0000549938d },
            { 940000.0d, 0.000055615d },
            { 950000.0d, 0.0000562375d },
            { 960000.0d, 0.0000568611d },
            { 970000.0d, 0.0000574857d },
            { 980000.0d, 0.0000581114d },
            { 990000.0d, 0.0000587382d },
            { 1000000.0d, 0.0000593659d },
            { 1035000.0d, 0.0000615703d },
            { 1070000.0d, 0.0000637852d },
            { 1105000.0d, 0.0000660092d },
            { 1140000.0d, 0.000068241d },
            { 1175000.0d, 0.0000704793d },
            { 1210000.0d, 0.0000727228d },
            { 1245000.0d, 0.0000749703d },
            { 1280000.0d, 0.0000772206d },
            { 1315000.0d, 0.0000794724d },
            { 1350000.0d, 0.0000817246d },
            { 1385000.0d, 0.0000839759d },
            { 1420000.0d, 0.0000862252d },
            { 1455000.0d, 0.0000884713d },
            { 1490000.0d, 0.0000907132d },
            { 1525000.0d, 0.0000929497d },
            { 1560000.0d, 0.0000951797d },
            { 1595000.0d, 0.0000974022d },
            { 1630000.0d, 0.000099616d },
            { 1665000.0d, 0.00010182d },
            { 1700000.0d, 0.000104014d },
            { 1735000.0d, 0.000106196d },
            { 1770000.0d, 0.000108365d },
            { 1805000.0d, 0.000110521d },
            { 1840000.0d, 0.000112662d },
            { 1875000.0d, 0.000114788d },
            { 1910000.0d, 0.000116898d },
            { 1945000.0d, 0.00011899d },
            { 1980000.0d, 0.000121064d },
            { 2015000.0d, 0.000123119d },
            { 2050000.0d, 0.000125155d },
            { 2085000.0d, 0.000127169d },
            { 2120000.0d, 0.000129163d },
            { 2155000.0d, 0.000131134d },
            { 2190000.0d, 0.000133082d },
            { 2225000.0d, 0.000135006d },
            { 2260000.0d, 0.000136906d },
            { 2295000.0d, 0.000138781d },
            { 2330000.0d, 0.000140629d },
            { 2365000.0d, 0.000142452d },
            { 2400000.0d, 0.000144247d },
            { 2435000.0d, 0.000146014d },
            { 2470000.0d, 0.000147752d },
            { 2505000.0d, 0.000149462d },
            { 2540000.0d, 0.000151141d },
            { 2575000.0d, 0.000152791d },
            { 2610000.0d, 0.000154409d },
            { 2645000.0d, 0.000155996d },
            { 2680000.0d, 0.000157551d },
            { 2715000.0d, 0.000159074d },
            { 2750000.0d, 0.000160563d },
            { 2785000.0d, 0.000162019d },
            { 2820000.0d, 0.000163441d },
            { 2855000.0d, 0.000164829d },
            { 2890000.0d, 0.000166182d },
            { 2925000.0d, 0.000167499d },
            { 2960000.0d, 0.000168781d },
            { 2995000.0d, 0.000170027d },
            { 3030000.0d, 0.000171236d },
            { 3065000.0d, 0.000172409d },
            { 3100000.0d, 0.000173544d },
            { 3135000.0d, 0.000174643d },
            { 3170000.0d, 0.000175703d },
            { 3205000.0d, 0.000176725d },
            { 3240000.0d, 0.000177709d },
            { 3275000.0d, 0.000178654d },
            { 3310000.0d, 0.00017956d },
            { 3345000.0d, 0.000180427d },
            { 3380000.0d, 0.000181255d },
            { 3415000.0d, 0.000182044d },
            { 3450000.0d, 0.000182792d },
            { 3485000.0d, 0.000183501d },
            { 3520000.0d, 0.00018417d },
            { 3555000.0d, 0.000184799d },
            { 3590000.0d, 0.000185387d },
            { 3625000.0d, 0.000185935d },
            { 3660000.0d, 0.000186442d },
            { 3695000.0d, 0.000186909d },
            { 3730000.0d, 0.000187335d },
            { 3765000.0d, 0.000187721d },
            { 3800000.0d, 0.000188066d },
            { 3835000.0d, 0.00018837d },
            { 3870000.0d, 0.000188633d },
            { 3905000.0d, 0.000188856d },
            { 3940000.0d, 0.000189037d },
            { 3975000.0d, 0.000189178d },
            { 4010000.0d, 0.000189279d },
            { 4045000.0d, 0.000189339d },
            { 4080000.0d, 0.000189358d },
            { 4115000.0d, 0.000189337d },
            { 4150000.0d, 0.000189276d },
            { 4185000.0d, 0.000189175d },
            { 4220000.0d, 0.000189033d },
            { 4255000.0d, 0.000188852d },
            { 4290000.0d, 0.000188631d },
            { 4325000.0d, 0.000188371d },
            { 4360000.0d, 0.000188071d },
            { 4395000.0d, 0.000187732d },
            { 4430000.0d, 0.000187354d },
            { 4465000.0d, 0.000186938d },
            { 4500000.0d, 0.000186483d },
            { 4535000.0d, 0.00018599d },
            { 4570000.0d, 0.00018546d },
            { 4605000.0d, 0.000184892d },
            { 4640000.0d, 0.000184286d },
            { 4675000.0d, 0.000183644d },
            { 4710000.0d, 0.000182965d },
            { 4745000.0d, 0.00018225d },
            { 4780000.0d, 0.000181499d },
            { 4815000.0d, 0.000180713d },
            { 4850000.0d, 0.000179892d },
            { 4885000.0d, 0.000179036d },
            { 4920000.0d, 0.000178145d },
            { 4955000.0d, 0.000177221d },
            { 4990000.0d, 0.000176264d },
            { 5025000.0d, 0.000175274d },
            { 5060000.0d, 0.000174251d },
            { 5095000.0d, 0.000173196d },
            { 5130000.0d, 0.00017211d },
            { 5165000.0d, 0.000170993d },
            { 5200000.0d, 0.000169846d },
            { 5235000.0d, 0.000168669d },
            { 5270000.0d, 0.000167463d },
            { 5305000.0d, 0.000166228d },
            { 5340000.0d, 0.000164965d },
            { 5375000.0d, 0.000163674d },
            { 5410000.0d, 0.000162356d },
            { 5445000.0d, 0.000161013d },
            { 5480000.0d, 0.000159643d },
            { 5515000.0d, 0.000158249d },
            { 5550000.0d, 0.00015683d },
            { 5585000.0d, 0.000155387d },
            { 5620000.0d, 0.000153922d },
            { 5655000.0d, 0.000152434d },
            { 5690000.0d, 0.000150925d },
            { 5725000.0d, 0.000149395d },
            { 5760000.0d, 0.000147845d },
            { 5795000.0d, 0.000146275d },
            { 5830000.0d, 0.000144687d },
            { 5865000.0d, 0.000143082d },
            { 5900000.0d, 0.000141459d },
            { 5935000.0d, 0.00013982d },
            { 5970000.0d, 0.000138165d },
            { 6005000.0d, 0.000136497d },
            { 6040000.0d, 0.000134814d },
            { 6075000.0d, 0.000133118d },
            { 6110000.0d, 0.000131411d },
            { 6145000.0d, 0.000129692d },
            { 6180000.0d, 0.000127963d },
            { 6215000.0d, 0.000126225d },
            { 6250000.0d, 0.000124478d },
            { 6285000.0d, 0.000122724d },
            { 6320000.0d, 0.000120963d },
            { 6355000.0d, 0.000119197d },
            { 6390000.0d, 0.000117425d },
            { 6425000.0d, 0.00011565d },
            { 6460000.0d, 0.000113872d },
            { 6495000.0d, 0.000112091d },
            { 6530000.0d, 0.000110309d },
            { 6565000.0d, 0.000108527d },
            { 6600000.0d, 0.000106745d },
            { 6635000.0d, 0.000104964d },
            { 6670000.0d, 0.000103185d },
            { 6705000.0d, 0.000101408d },
            { 6740000.0d, 0.0000996343d },
            { 6775000.0d, 0.0000978651d },
            { 6810000.0d, 0.0000961007d },
            { 6845000.0d, 0.0000943399d },
            { 6880000.0d, 0.0000925834d },
            { 6915000.0d, 0.0000908323d },
            { 6950000.0d, 0.0000890873d },
            { 6985000.0d, 0.0000873495d },
            { 7020000.0d, 0.0000856178d },
            { 7055000.0d, 0.0000838896d },
            { 7090000.0d, 0.0000821656d },
            { 7125000.0d, 0.0000804469d },
            { 7160000.0d, 0.0000787343d },
            { 7195000.0d, 0.0000770287d },
            { 7230000.0d, 0.0000753301d },
            { 7265000.0d, 0.0000736392d },
            { 7300000.0d, 0.0000719566d },
            { 7335000.0d, 0.0000702834d },
            { 7370000.0d, 0.0000686205d },
            { 7405000.0d, 0.0000669688d },
            { 7440000.0d, 0.0000653291d },
            { 7475000.0d, 0.0000637026d },
            { 7510000.0d, 0.0000620902d },
            { 7545000.0d, 0.0000604927d },
            { 7580000.0d, 0.0000589111d },
            { 7615000.0d, 0.0000573451d },
            { 7650000.0d, 0.0000557922d },
            { 7685000.0d, 0.000054253d },
            { 7720000.0d, 0.0000527286d },
            { 7755000.0d, 0.0000512193d },
            { 7790000.0d, 0.0000497232d },
            { 7825000.0d, 0.0000482408d },
            { 7860000.0d, 0.0000467727d },
            { 7895000.0d, 0.0000453199d },
            { 7930000.0d, 0.0000438831d },
            { 7965000.0d, 0.0000424631d },
            { 8000000.0d, 0.0000410609d },
            { 8035000.0d, 0.0000396774d },
            { 8070000.0d, 0.000038312d },
            { 8105000.0d, 0.0000369637d },
            { 8140000.0d, 0.0000356334d },
            { 8175000.0d, 0.0000343215d },
            { 8210000.0d, 0.0000330289d },
            { 8245000.0d, 0.0000317563d },
            { 8280000.0d, 0.0000305043d },
            { 8315000.0d, 0.0000292738d },
            { 8350000.0d, 0.0000280655d },
            { 8385000.0d, 0.0000268803d },
            { 8420000.0d, 0.0000257191d },
            { 8455000.0d, 0.0000245824d },
            { 8490000.0d, 0.0000234705d },
            { 8525000.0d, 0.0000223842d },
            { 8560000.0d, 0.0000213233d },
            { 8595000.0d, 0.0000202848d },
            { 8630000.0d, 0.0000192692d },
            { 8665000.0d, 0.0000182772d },
            { 8700000.0d, 0.0000173095d },
            { 8735000.0d, 0.0000163667d },
            { 8770000.0d, 0.0000154484d },
            { 8805000.0d, 0.0000145528d },
            { 8840000.0d, 0.0000136806d },
            { 8875000.0d, 0.0000128324d },
            { 8910000.0d, 0.000012009d },
            { 8945000.0d, 0.0000112111d },
            { 8980000.0d, 0.0000104388d },
            { 9015000.0d, 0.00000969256d },
            { 9050000.0d, 0.000008973d },
            { 9085000.0d, 0.00000828079d },
            { 9120000.0d, 0.00000761665d },
            { 9155000.0d, 0.00000698126d },
            { 9190000.0d, 0.00000637531d },
            { 9225000.0d, 0.00000579859d },
            { 9260000.0d, 0.00000524936d },
            { 9295000.0d, 0.00000472814d },
            { 9330000.0d, 0.00000423559d },
            { 9365000.0d, 0.00000377234d },
            { 9400000.0d, 0.00000333905d },
            { 9435000.0d, 0.00000293627d },
            { 9470000.0d, 0.00000256441d },
            { 9505000.0d, 0.00000222202d },
            { 9540000.0d, 0.00000190894d },
            { 9575000.0d, 0.00000162574d },
            { 9610000.0d, 0.0000013728d },
            { 9645000.0d, 0.00000114811d },
            { 9680000.0d, 0.000000949685d },
            { 9715000.0d, 0.000000777989d },
            { 9750000.0d, 0.00000063344d },
            { 9785000.0d, 0.000000512276d },
            { 9820000.0d, 0.000000409222d },
            { 9855000.0d, 0.000000324206d },
            { 9890000.0d, 0.000000257519d },
            { 9925000.0d, 0.000000209432d },
            { 9960000.0d, 0.000000180144d },
            { 9995000.0d, 0.000000164982d },
            { 10030000.0d, 0.000000151072d },
            { 10065000.0d, 0.000000137692d },
            { 10100000.0d, 0.000000124854d },
            { 10135000.0d, 0.00000011257d },
            { 10170000.0d, 0.000000100853d },
            { 10205000.0d, 0.0000000897144d },
            { 10240000.0d, 0.0000000791663d },
            { 10275000.0d, 0.0000000692209d },
            { 10310000.0d, 0.0000000598906d },
            { 10345000.0d, 0.0000000511875d },
            { 10380000.0d, 0.0000000431237d },
            { 10415000.0d, 0.0000000357115d },
            { 10450000.0d, 0.0000000289629d },
            { 10485000.0d, 0.0000000228901d },
            { 10520000.0d, 0.0000000175049d },
            { 10555000.0d, 0.0000000128193d },
            { 10590000.0d, 0.0000000088447d },
            { 10625000.0d, 0.0000000055926d },
            { 10660000.0d, 0.0000000030739d },
            { 10695000.0d, 0.00000000129866d },
            { 10730000.0d, 0.000000000275366d },
            { 10760000.0d, 0d },

        }; 
    }
}
    