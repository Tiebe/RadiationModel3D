using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium130";
        public override double halfLife { get; } = 0.162d;
        public override double atomicWeight { get; } = 129.93439d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.022400000000000003d, new GammaParticle(388700.0, 0.00319)), new(0.49616d, new GammaParticle(451000.0, 0.00275)), new(0.12376d, new GammaParticle(949900.0, 0.00131)), new(0.0308d, new GammaParticle(1015500.0, 0.00122)), new(0.009519999999999999d, new GammaParticle(1138400.0, 0.00109)), new(0.11199999999999999d, new GammaParticle(1170300.0, 0.00106)), new(0.013999999999999999d, new GammaParticle(1314400.0, 0.00094)), new(0.56d, new GammaParticle(1669200.0, 0.00074)), new(0.02464d, new GammaParticle(1731800.0, 0.00072)), new(0.06216d, new GammaParticle(2120100.0, 0.00058)), new(0.00728d, new GammaParticle(2585500.0, 0.00048)), new(0.00728d, new GammaParticle(2738300.0, 0.00045)), new(0.00616d, new GammaParticle(2804900.0, 0.00044)), new(0.0028000000000000004d, new GammaParticle(4407000.0, 0.00028)), new(0.00336d, new GammaParticle(4631000.0, 0.00027)), new(0.00616d, new GammaParticle(5098000.0, 0.00024)), new(0.00392d, new GammaParticle(5196000.0, 0.00024)), new(0.0022400000000000002d, new GammaParticle(5391000.0, 0.00023)) } },
            { 0.035d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.022400000000000003d, new GammaParticle(388700.0, 0.00319)), new(0.49616d, new GammaParticle(451000.0, 0.00275)), new(0.12376d, new GammaParticle(949900.0, 0.00131)), new(0.0308d, new GammaParticle(1015500.0, 0.00122)), new(0.009519999999999999d, new GammaParticle(1138400.0, 0.00109)), new(0.11199999999999999d, new GammaParticle(1170300.0, 0.00106)), new(0.013999999999999999d, new GammaParticle(1314400.0, 0.00094)), new(0.56d, new GammaParticle(1669200.0, 0.00074)), new(0.02464d, new GammaParticle(1731800.0, 0.00072)), new(0.06216d, new GammaParticle(2120100.0, 0.00058)), new(0.00728d, new GammaParticle(2585500.0, 0.00048)), new(0.00728d, new GammaParticle(2738300.0, 0.00045)), new(0.00616d, new GammaParticle(2804900.0, 0.00044)), new(0.0028000000000000004d, new GammaParticle(4407000.0, 0.00028)), new(0.00336d, new GammaParticle(4631000.0, 0.00027)), new(0.00616d, new GammaParticle(5098000.0, 0.00024)), new(0.00392d, new GammaParticle(5196000.0, 0.00024)), new(0.0022400000000000002d, new GammaParticle(5391000.0, 0.00023)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000258764d },
            { 9000.0d, 0.0000265649d },
            { 18000.0d, 0.000027268d },
            { 27000.0d, 0.0000279857d },
            { 36000.0d, 0.0000287194d },
            { 45000.0d, 0.0000294702d },
            { 54000.0d, 0.0000302384d },
            { 63000.0d, 0.0000310238d },
            { 72000.0d, 0.0000318257d },
            { 81000.0d, 0.0000326437d },
            { 90000.0d, 0.0000334739d },
            { 99000.0d, 0.0000343173d },
            { 108000.0d, 0.0000351713d },
            { 118000.0d, 0.0000361327d },
            { 128000.0d, 0.0000371055d },
            { 138000.0d, 0.0000380894d },
            { 148000.0d, 0.000039083d },
            { 158000.0d, 0.0000400863d },
            { 168000.0d, 0.0000410982d },
            { 178000.0d, 0.0000421187d },
            { 188000.0d, 0.0000431468d },
            { 198000.0d, 0.0000441826d },
            { 208000.0d, 0.0000452254d },
            { 218000.0d, 0.0000462752d },
            { 228000.0d, 0.0000473313d },
            { 238000.0d, 0.0000483937d },
            { 248000.0d, 0.0000494619d },
            { 258000.0d, 0.0000505359d },
            { 268000.0d, 0.0000516152d },
            { 278000.0d, 0.0000526999d },
            { 288000.0d, 0.0000537894d },
            { 298000.0d, 0.0000548838d },
            { 308000.0d, 0.0000559828d },
            { 318000.0d, 0.0000570861d },
            { 328000.0d, 0.0000581936d },
            { 338000.0d, 0.0000593052d },
            { 348000.0d, 0.0000604206d },
            { 358000.0d, 0.0000615396d },
            { 368000.0d, 0.0000626621d },
            { 378000.0d, 0.000063788d },
            { 388000.0d, 0.000064917d },
            { 398000.0d, 0.000066049d },
            { 408000.0d, 0.0000671838d },
            { 418000.0d, 0.0000683214d },
            { 428000.0d, 0.0000694614d },
            { 438000.0d, 0.0000706039d },
            { 448000.0d, 0.0000717485d },
            { 458000.0d, 0.0000728954d },
            { 468000.0d, 0.0000740441d },
            { 478000.0d, 0.0000751946d },
            { 488000.0d, 0.0000763468d },
            { 498000.0d, 0.0000775005d },
            { 508000.0d, 0.0000786556d },
            { 518000.0d, 0.000079812d },
            { 528000.0d, 0.0000809695d },
            { 538000.0d, 0.000082128d },
            { 548000.0d, 0.0000832873d },
            { 558000.0d, 0.0000844475d },
            { 568000.0d, 0.0000856082d },
            { 578000.0d, 0.0000867694d },
            { 588000.0d, 0.0000879309d },
            { 598000.0d, 0.0000890927d },
            { 608000.0d, 0.0000902546d },
            { 618000.0d, 0.0000914165d },
            { 628000.0d, 0.0000925782d },
            { 638000.0d, 0.0000937398d },
            { 648000.0d, 0.000094901d },
            { 658000.0d, 0.0000960617d },
            { 668000.0d, 0.0000972218d },
            { 678000.0d, 0.0000983812d },
            { 688000.0d, 0.0000995398d },
            { 698000.0d, 0.000100698d },
            { 708000.0d, 0.000101854d },
            { 718000.0d, 0.00010301d },
            { 728000.0d, 0.000104164d },
            { 738000.0d, 0.000105317d },
            { 748000.0d, 0.000106468d },
            { 758000.0d, 0.000107618d },
            { 768000.0d, 0.000108766d },
            { 778000.0d, 0.000109913d },
            { 788000.0d, 0.000111058d },
            { 798000.0d, 0.0001122d },
            { 808000.0d, 0.000113341d },
            { 818000.0d, 0.000114479d },
            { 828000.0d, 0.000115615d },
            { 838000.0d, 0.000116749d },
            { 848000.0d, 0.00011788d },
            { 858000.0d, 0.000119009d },
            { 868000.0d, 0.000120136d },
            { 878000.0d, 0.000121259d },
            { 888000.0d, 0.00012238d },
            { 898000.0d, 0.000123497d },
            { 908000.0d, 0.000124612d },
            { 918000.0d, 0.000125724d },
            { 928000.0d, 0.000126832d },
            { 938000.0d, 0.000127938d },
            { 948000.0d, 0.00012904d },
            { 958000.0d, 0.000130138d },
            { 968000.0d, 0.000131233d },
            { 978000.0d, 0.000132324d },
            { 988000.0d, 0.000133412d },
            { 998000.0d, 0.000134496d },
            { 1008000.0d, 0.000135576d },
            { 1035000.0d, 0.000138473d },
            { 1062000.0d, 0.000141339d },
            { 1089000.0d, 0.000144175d },
            { 1116000.0d, 0.000146977d },
            { 1143000.0d, 0.000149745d },
            { 1170000.0d, 0.000152478d },
            { 1197000.0d, 0.000155173d },
            { 1224000.0d, 0.00015783d },
            { 1251000.0d, 0.000160449d },
            { 1278000.0d, 0.000163026d },
            { 1305000.0d, 0.000165562d },
            { 1332000.0d, 0.000168057d },
            { 1359000.0d, 0.000170507d },
            { 1386000.0d, 0.000172913d },
            { 1413000.0d, 0.000175272d },
            { 1440000.0d, 0.000177586d },
            { 1467000.0d, 0.000179852d },
            { 1494000.0d, 0.00018207d },
            { 1521000.0d, 0.00018424d },
            { 1548000.0d, 0.00018636d },
            { 1575000.0d, 0.000188429d },
            { 1602000.0d, 0.000190447d },
            { 1629000.0d, 0.000192415d },
            { 1656000.0d, 0.00019433d },
            { 1683000.0d, 0.000196192d },
            { 1710000.0d, 0.000198001d },
            { 1737000.0d, 0.000199756d },
            { 1764000.0d, 0.000201458d },
            { 1791000.0d, 0.000203105d },
            { 1818000.0d, 0.000204697d },
            { 1845000.0d, 0.000206234d },
            { 1872000.0d, 0.000207715d },
            { 1899000.0d, 0.000209141d },
            { 1926000.0d, 0.000210512d },
            { 1953000.0d, 0.000211826d },
            { 1980000.0d, 0.000213084d },
            { 2007000.0d, 0.000214285d },
            { 2034000.0d, 0.000215431d },
            { 2061000.0d, 0.00021652d },
            { 2088000.0d, 0.000217553d },
            { 2115000.0d, 0.00021853d },
            { 2142000.0d, 0.00021945d },
            { 2169000.0d, 0.000220314d },
            { 2196000.0d, 0.000221121d },
            { 2223000.0d, 0.000221874d },
            { 2250000.0d, 0.00022257d },
            { 2277000.0d, 0.000223211d },
            { 2304000.0d, 0.000223798d },
            { 2331000.0d, 0.000224329d },
            { 2358000.0d, 0.000224805d },
            { 2385000.0d, 0.000225228d },
            { 2412000.0d, 0.000225597d },
            { 2439000.0d, 0.000225912d },
            { 2466000.0d, 0.000226175d },
            { 2493000.0d, 0.000226385d },
            { 2520000.0d, 0.000226544d },
            { 2547000.0d, 0.000226651d },
            { 2574000.0d, 0.000226707d },
            { 2601000.0d, 0.000226714d },
            { 2628000.0d, 0.00022667d },
            { 2655000.0d, 0.000226578d },
            { 2682000.0d, 0.000226439d },
            { 2709000.0d, 0.000226251d },
            { 2736000.0d, 0.000226018d },
            { 2763000.0d, 0.000225738d },
            { 2790000.0d, 0.000225413d },
            { 2817000.0d, 0.000225045d },
            { 2844000.0d, 0.000224632d },
            { 2871000.0d, 0.000224178d },
            { 2898000.0d, 0.000223682d },
            { 2925000.0d, 0.000223145d },
            { 2952000.0d, 0.000222569d },
            { 2979000.0d, 0.000221949d },
            { 3006000.0d, 0.000221283d },
            { 3033000.0d, 0.000220571d },
            { 3060000.0d, 0.000219814d },
            { 3087000.0d, 0.000219013d },
            { 3114000.0d, 0.000218168d },
            { 3141000.0d, 0.000217281d },
            { 3168000.0d, 0.000216349d },
            { 3195000.0d, 0.000215372d },
            { 3222000.0d, 0.000214353d },
            { 3249000.0d, 0.000213291d },
            { 3276000.0d, 0.000212182d },
            { 3303000.0d, 0.000211028d },
            { 3330000.0d, 0.000209828d },
            { 3357000.0d, 0.000208583d },
            { 3384000.0d, 0.000207294d },
            { 3411000.0d, 0.000205962d },
            { 3438000.0d, 0.000204588d },
            { 3465000.0d, 0.000203172d },
            { 3492000.0d, 0.000201714d },
            { 3519000.0d, 0.000200215d },
            { 3546000.0d, 0.000198678d },
            { 3573000.0d, 0.000197101d },
            { 3600000.0d, 0.000195487d },
            { 3627000.0d, 0.000193836d },
            { 3654000.0d, 0.000192148d },
            { 3681000.0d, 0.000190426d },
            { 3708000.0d, 0.000188668d },
            { 3735000.0d, 0.000186877d },
            { 3762000.0d, 0.000185051d },
            { 3789000.0d, 0.000183192d },
            { 3816000.0d, 0.0001813d },
            { 3843000.0d, 0.000179377d },
            { 3870000.0d, 0.000177424d },
            { 3897000.0d, 0.000175442d },
            { 3924000.0d, 0.000173431d },
            { 3951000.0d, 0.00017139d },
            { 3978000.0d, 0.000169319d },
            { 4005000.0d, 0.000167218d },
            { 4032000.0d, 0.000165088d },
            { 4059000.0d, 0.000162929d },
            { 4086000.0d, 0.000160743d },
            { 4113000.0d, 0.000158531d },
            { 4140000.0d, 0.000156294d },
            { 4167000.0d, 0.000154032d },
            { 4194000.0d, 0.000151746d },
            { 4221000.0d, 0.000149438d },
            { 4248000.0d, 0.000147108d },
            { 4275000.0d, 0.000144759d },
            { 4302000.0d, 0.000142391d },
            { 4329000.0d, 0.000140003d },
            { 4356000.0d, 0.000137599d },
            { 4383000.0d, 0.000135179d },
            { 4410000.0d, 0.000132744d },
            { 4437000.0d, 0.000130295d },
            { 4464000.0d, 0.000127834d },
            { 4491000.0d, 0.000125361d },
            { 4518000.0d, 0.000122878d },
            { 4545000.0d, 0.000120386d },
            { 4572000.0d, 0.000117886d },
            { 4599000.0d, 0.000115379d },
            { 4626000.0d, 0.000112866d },
            { 4653000.0d, 0.00011035d },
            { 4680000.0d, 0.00010783d },
            { 4707000.0d, 0.000105309d },
            { 4734000.0d, 0.000102787d },
            { 4761000.0d, 0.000100267d },
            { 4788000.0d, 0.0000977479d },
            { 4815000.0d, 0.0000952327d },
            { 4842000.0d, 0.0000927223d },
            { 4869000.0d, 0.0000902181d },
            { 4896000.0d, 0.0000877214d },
            { 4923000.0d, 0.0000852335d },
            { 4950000.0d, 0.000082756d },
            { 4977000.0d, 0.0000802901d },
            { 5004000.0d, 0.0000778373d },
            { 5031000.0d, 0.000075399d },
            { 5058000.0d, 0.0000729766d },
            { 5085000.0d, 0.0000705716d },
            { 5112000.0d, 0.0000681854d },
            { 5139000.0d, 0.0000658195d },
            { 5166000.0d, 0.0000634755d },
            { 5193000.0d, 0.0000611546d },
            { 5220000.0d, 0.0000588586d },
            { 5247000.0d, 0.0000565889d },
            { 5274000.0d, 0.000054347d },
            { 5301000.0d, 0.0000521344d },
            { 5328000.0d, 0.0000499528d },
            { 5355000.0d, 0.0000478037d },
            { 5382000.0d, 0.0000456886d },
            { 5409000.0d, 0.0000436092d },
            { 5436000.0d, 0.000041567d },
            { 5463000.0d, 0.0000395637d },
            { 5490000.0d, 0.0000376009d },
            { 5517000.0d, 0.0000356801d },
            { 5544000.0d, 0.0000338031d },
            { 5571000.0d, 0.0000319714d },
            { 5598000.0d, 0.0000301868d },
            { 5625000.0d, 0.0000284508d },
            { 5652000.0d, 0.0000267654d },
            { 5679000.0d, 0.0000251319d },
            { 5706000.0d, 0.0000235522d },
            { 5733000.0d, 0.0000220279d },
            { 5760000.0d, 0.0000205608d },
            { 5787000.0d, 0.0000191525d },
            { 5814000.0d, 0.0000178047d },
            { 5841000.0d, 0.000016519d },
            { 5868000.0d, 0.0000152973d },
            { 5895000.0d, 0.0000141412d },
            { 5922000.0d, 0.0000130526d },
            { 5949000.0d, 0.0000120331d },
            { 5976000.0d, 0.0000110846d },
            { 6003000.0d, 0.0000102086d },
            { 6030000.0d, 0.00000940716d },
            { 6057000.0d, 0.00000868179d },
            { 6084000.0d, 0.0000080343d },
            { 6111000.0d, 0.00000746641d },
            { 6138000.0d, 0.00000697973d },
            { 6165000.0d, 0.00000657595d },
            { 6192000.0d, 0.00000625655d },
            { 6219000.0d, 0.00000602268d },
            { 6246000.0d, 0.00000583668d },
            { 6273000.0d, 0.00000565505d },
            { 6300000.0d, 0.00000547788d },
            { 6327000.0d, 0.00000530529d },
            { 6354000.0d, 0.00000513743d },
            { 6381000.0d, 0.00000497443d },
            { 6408000.0d, 0.00000481645d },
            { 6435000.0d, 0.00000466361d },
            { 6462000.0d, 0.00000451605d },
            { 6489000.0d, 0.00000437392d },
            { 6516000.0d, 0.00000423736d },
            { 6543000.0d, 0.0000041065d },
            { 6570000.0d, 0.00000398147d },
            { 6597000.0d, 0.00000386242d },
            { 6624000.0d, 0.00000374946d },
            { 6651000.0d, 0.00000364273d },
            { 6678000.0d, 0.00000354205d },
            { 6705000.0d, 0.00000344356d },
            { 6732000.0d, 0.00000334591d },
            { 6759000.0d, 0.00000324917d },
            { 6786000.0d, 0.00000315336d },
            { 6813000.0d, 0.00000305854d },
            { 6840000.0d, 0.00000296473d },
            { 6867000.0d, 0.00000287199d },
            { 6894000.0d, 0.00000278035d },
            { 6921000.0d, 0.00000268985d },
            { 6948000.0d, 0.00000260053d },
            { 6975000.0d, 0.00000251244d },
            { 7002000.0d, 0.00000242561d },
            { 7029000.0d, 0.00000234009d },
            { 7056000.0d, 0.00000225593d },
            { 7083000.0d, 0.00000217316d },
            { 7110000.0d, 0.00000209182d },
            { 7137000.0d, 0.00000201196d },
            { 7164000.0d, 0.00000193361d },
            { 7191000.0d, 0.00000185663d },
            { 7218000.0d, 0.00000178073d },
            { 7245000.0d, 0.00000170589d },
            { 7272000.0d, 0.00000163216d },
            { 7299000.0d, 0.00000155957d },
            { 7326000.0d, 0.00000148816d },
            { 7353000.0d, 0.00000141797d },
            { 7380000.0d, 0.00000134902d },
            { 7407000.0d, 0.00000128135d },
            { 7434000.0d, 0.000001215d },
            { 7461000.0d, 0.00000115001d },
            { 7488000.0d, 0.0000010864d },
            { 7515000.0d, 0.00000102421d },
            { 7542000.0d, 0.000000963481d },
            { 7569000.0d, 0.000000904248d },
            { 7596000.0d, 0.000000846545d },
            { 7623000.0d, 0.000000790409d },
            { 7650000.0d, 0.000000735874d },
            { 7677000.0d, 0.000000682979d },
            { 7704000.0d, 0.000000631759d },
            { 7731000.0d, 0.00000058225d },
            { 7758000.0d, 0.00000053449d },
            { 7785000.0d, 0.000000488514d },
            { 7812000.0d, 0.00000044436d },
            { 7839000.0d, 0.000000402064d },
            { 7866000.0d, 0.000000361664d },
            { 7893000.0d, 0.000000323195d },
            { 7920000.0d, 0.000000286695d },
            { 7947000.0d, 0.000000252202d },
            { 7974000.0d, 0.000000219753d },
            { 8001000.0d, 0.000000189383d },
            { 8028000.0d, 0.00000016113d },
            { 8055000.0d, 0.000000135031d },
            { 8082000.0d, 0.000000111122d },
            { 8109000.0d, 0.0000000894399d },
            { 8136000.0d, 0.0000000700216d },
            { 8163000.0d, 0.0000000529027d },
            { 8190000.0d, 0.0000000381184d },
            { 8217000.0d, 0.0000000257037d },
            { 8244000.0d, 0.0000000156922d },
            { 8271000.0d, 0.00000000811595d },
            { 8298000.0d, 0.00000000300432d },
            { 8325000.0d, 0.000000000379714d },
            { 8340000.0d, 0d },

        }; 
    }
}
    