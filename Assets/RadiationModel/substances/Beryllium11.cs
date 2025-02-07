using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium11 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium11";
        public override double halfLife { get; } = 13.76d;
        public override double atomicWeight { get; } = 11.02166d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Boron11()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.031d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Boron11()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 8.3e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Boron11()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000661772d },
            { 5000.0d, 0.00000812505d },
            { 10000.0d, 0.00000946545d },
            { 15000.0d, 0.0000106389d },
            { 20000.0d, 0.0000117062d },
            { 25000.0d, 0.0000126964d },
            { 30000.0d, 0.0000136257d },
            { 35000.0d, 0.0000145068d },
            { 40000.0d, 0.0000153517d },
            { 45000.0d, 0.0000161629d },
            { 50000.0d, 0.0000169523d },
            { 55000.0d, 0.0000177185d },
            { 60000.0d, 0.0000184655d },
            { 65000.0d, 0.0000191962d },
            { 70000.0d, 0.0000199116d },
            { 75000.0d, 0.000020613d },
            { 80000.0d, 0.0000213023d },
            { 85000.0d, 0.0000219801d },
            { 90000.0d, 0.0000226469d },
            { 95000.0d, 0.0000233052d },
            { 100000.0d, 0.0000239561d },
            { 110000.0d, 0.0000252341d },
            { 120000.0d, 0.0000264864d },
            { 130000.0d, 0.0000277176d },
            { 140000.0d, 0.0000289286d },
            { 150000.0d, 0.0000301204d },
            { 160000.0d, 0.0000312963d },
            { 170000.0d, 0.0000324572d },
            { 180000.0d, 0.0000336034d },
            { 190000.0d, 0.0000347356d },
            { 200000.0d, 0.0000358554d },
            { 210000.0d, 0.0000369627d },
            { 220000.0d, 0.0000380578d },
            { 230000.0d, 0.0000391412d },
            { 240000.0d, 0.0000402133d },
            { 250000.0d, 0.000041274d },
            { 260000.0d, 0.0000423236d },
            { 270000.0d, 0.0000433622d },
            { 280000.0d, 0.0000443899d },
            { 290000.0d, 0.0000454067d },
            { 300000.0d, 0.0000464126d },
            { 310000.0d, 0.0000474077d },
            { 320000.0d, 0.0000483919d },
            { 330000.0d, 0.0000493652d },
            { 340000.0d, 0.0000503274d },
            { 350000.0d, 0.0000512788d },
            { 360000.0d, 0.000052219d },
            { 370000.0d, 0.0000531482d },
            { 380000.0d, 0.0000540661d },
            { 390000.0d, 0.0000549728d },
            { 400000.0d, 0.0000558681d },
            { 410000.0d, 0.000056752d },
            { 420000.0d, 0.0000576244d },
            { 430000.0d, 0.0000584852d },
            { 440000.0d, 0.0000593345d },
            { 450000.0d, 0.000060172d },
            { 460000.0d, 0.0000609977d },
            { 470000.0d, 0.0000618116d },
            { 480000.0d, 0.0000626135d },
            { 490000.0d, 0.0000634034d },
            { 500000.0d, 0.0000641813d },
            { 510000.0d, 0.0000649471d },
            { 520000.0d, 0.0000657007d },
            { 530000.0d, 0.0000664421d },
            { 540000.0d, 0.0000671713d },
            { 550000.0d, 0.0000678881d },
            { 560000.0d, 0.0000685925d },
            { 570000.0d, 0.0000692846d },
            { 580000.0d, 0.0000699644d },
            { 590000.0d, 0.0000706316d },
            { 600000.0d, 0.0000712865d },
            { 610000.0d, 0.0000719289d },
            { 620000.0d, 0.0000725588d },
            { 630000.0d, 0.0000731763d },
            { 640000.0d, 0.0000737813d },
            { 650000.0d, 0.000074374d },
            { 660000.0d, 0.0000749542d },
            { 670000.0d, 0.000075522d },
            { 680000.0d, 0.0000760775d },
            { 690000.0d, 0.0000766205d },
            { 700000.0d, 0.0000771513d },
            { 710000.0d, 0.0000776698d },
            { 720000.0d, 0.0000781762d },
            { 730000.0d, 0.0000786704d },
            { 740000.0d, 0.0000791526d },
            { 750000.0d, 0.0000796227d },
            { 760000.0d, 0.0000800809d },
            { 770000.0d, 0.0000805272d },
            { 780000.0d, 0.0000809618d },
            { 790000.0d, 0.0000813848d },
            { 800000.0d, 0.0000817962d },
            { 810000.0d, 0.0000821961d },
            { 820000.0d, 0.0000825848d },
            { 830000.0d, 0.0000829623d },
            { 840000.0d, 0.0000833285d },
            { 850000.0d, 0.0000836838d },
            { 860000.0d, 0.0000840284d },
            { 870000.0d, 0.0000843623d },
            { 880000.0d, 0.0000846857d },
            { 890000.0d, 0.0000849988d },
            { 900000.0d, 0.0000853017d },
            { 910000.0d, 0.0000855946d },
            { 920000.0d, 0.0000858776d },
            { 930000.0d, 0.000086151d },
            { 940000.0d, 0.000086415d },
            { 950000.0d, 0.0000866697d },
            { 960000.0d, 0.0000869153d },
            { 970000.0d, 0.0000871521d },
            { 980000.0d, 0.0000873802d },
            { 990000.0d, 0.0000876001d },
            { 1000000.0d, 0.0000878117d },
            { 1038000.0d, 0.0000885459d },
            { 1076000.0d, 0.0000891795d },
            { 1114000.0d, 0.000089728d },
            { 1152000.0d, 0.0000902079d },
            { 1190000.0d, 0.0000906373d },
            { 1228000.0d, 0.0000910355d },
            { 1266000.0d, 0.0000914232d },
            { 1304000.0d, 0.0000918222d },
            { 1342000.0d, 0.000092256d },
            { 1380000.0d, 0.0000927494d },
            { 1418000.0d, 0.0000933282d },
            { 1456000.0d, 0.0000940197d },
            { 1494000.0d, 0.0000948524d },
            { 1532000.0d, 0.0000958562d },
            { 1570000.0d, 0.0000970618d },
            { 1608000.0d, 0.0000985011d },
            { 1646000.0d, 0.000100186d },
            { 1684000.0d, 0.000101895d },
            { 1722000.0d, 0.000103558d },
            { 1760000.0d, 0.000105173d },
            { 1798000.0d, 0.00010674d },
            { 1836000.0d, 0.000108259d },
            { 1874000.0d, 0.00010973d },
            { 1912000.0d, 0.000111152d },
            { 1950000.0d, 0.000112524d },
            { 1988000.0d, 0.000113848d },
            { 2026000.0d, 0.000115123d },
            { 2064000.0d, 0.000116349d },
            { 2102000.0d, 0.000117527d },
            { 2140000.0d, 0.000118656d },
            { 2178000.0d, 0.000119737d },
            { 2216000.0d, 0.000120771d },
            { 2254000.0d, 0.000121758d },
            { 2292000.0d, 0.000122699d },
            { 2330000.0d, 0.000123595d },
            { 2368000.0d, 0.000124447d },
            { 2406000.0d, 0.000125255d },
            { 2444000.0d, 0.000126021d },
            { 2482000.0d, 0.000126745d },
            { 2520000.0d, 0.00012743d },
            { 2558000.0d, 0.000128076d },
            { 2596000.0d, 0.000128685d },
            { 2634000.0d, 0.000129258d },
            { 2672000.0d, 0.000129797d },
            { 2710000.0d, 0.000130304d },
            { 2748000.0d, 0.00013078d },
            { 2786000.0d, 0.000131228d },
            { 2824000.0d, 0.000131649d },
            { 2862000.0d, 0.000132046d },
            { 2900000.0d, 0.000132419d },
            { 2938000.0d, 0.000132773d },
            { 2976000.0d, 0.000133109d },
            { 3014000.0d, 0.000133429d },
            { 3052000.0d, 0.000133737d },
            { 3090000.0d, 0.000134034d },
            { 3128000.0d, 0.000134323d },
            { 3166000.0d, 0.000134608d },
            { 3204000.0d, 0.00013489d },
            { 3242000.0d, 0.000135174d },
            { 3280000.0d, 0.000135461d },
            { 3318000.0d, 0.000135755d },
            { 3356000.0d, 0.000136059d },
            { 3394000.0d, 0.000136377d },
            { 3432000.0d, 0.000136712d },
            { 3470000.0d, 0.000137067d },
            { 3508000.0d, 0.000137445d },
            { 3546000.0d, 0.000137845d },
            { 3584000.0d, 0.000138231d },
            { 3622000.0d, 0.000138593d },
            { 3660000.0d, 0.000138932d },
            { 3698000.0d, 0.000139248d },
            { 3736000.0d, 0.000139543d },
            { 3774000.0d, 0.000139817d },
            { 3812000.0d, 0.000140071d },
            { 3850000.0d, 0.000140307d },
            { 3888000.0d, 0.000140525d },
            { 3926000.0d, 0.000140726d },
            { 3964000.0d, 0.000140911d },
            { 4002000.0d, 0.000141082d },
            { 4040000.0d, 0.000141239d },
            { 4078000.0d, 0.000141383d },
            { 4116000.0d, 0.000141517d },
            { 4154000.0d, 0.00014164d },
            { 4192000.0d, 0.000141755d },
            { 4230000.0d, 0.000141862d },
            { 4268000.0d, 0.000141963d },
            { 4306000.0d, 0.000142058d },
            { 4344000.0d, 0.000142149d },
            { 4382000.0d, 0.000142238d },
            { 4420000.0d, 0.000142325d },
            { 4458000.0d, 0.000142413d },
            { 4496000.0d, 0.000142502d },
            { 4534000.0d, 0.000142594d },
            { 4572000.0d, 0.000142691d },
            { 4610000.0d, 0.000142793d },
            { 4648000.0d, 0.000142904d },
            { 4686000.0d, 0.000143023d },
            { 4724000.0d, 0.000143151d },
            { 4762000.0d, 0.000143266d },
            { 4800000.0d, 0.000143353d },
            { 4838000.0d, 0.000143412d },
            { 4876000.0d, 0.000143444d },
            { 4914000.0d, 0.000143449d },
            { 4952000.0d, 0.000143427d },
            { 4990000.0d, 0.000143377d },
            { 5028000.0d, 0.0001433d },
            { 5066000.0d, 0.000143196d },
            { 5104000.0d, 0.000143065d },
            { 5142000.0d, 0.000142907d },
            { 5180000.0d, 0.000142723d },
            { 5218000.0d, 0.000142511d },
            { 5256000.0d, 0.000142273d },
            { 5294000.0d, 0.000142008d },
            { 5332000.0d, 0.000141717d },
            { 5370000.0d, 0.0001414d },
            { 5408000.0d, 0.000141056d },
            { 5446000.0d, 0.000140687d },
            { 5484000.0d, 0.000140291d },
            { 5522000.0d, 0.00013987d },
            { 5560000.0d, 0.000139424d },
            { 5598000.0d, 0.000138952d },
            { 5636000.0d, 0.000138455d },
            { 5674000.0d, 0.000137933d },
            { 5712000.0d, 0.000137386d },
            { 5750000.0d, 0.000136815d },
            { 5788000.0d, 0.00013622d },
            { 5826000.0d, 0.000135601d },
            { 5864000.0d, 0.000134958d },
            { 5902000.0d, 0.000134291d },
            { 5940000.0d, 0.000133601d },
            { 5978000.0d, 0.000132889d },
            { 6016000.0d, 0.000132153d },
            { 6054000.0d, 0.000131395d },
            { 6092000.0d, 0.000130615d },
            { 6130000.0d, 0.000129813d },
            { 6168000.0d, 0.00012899d },
            { 6206000.0d, 0.000128145d },
            { 6244000.0d, 0.00012728d },
            { 6282000.0d, 0.000126393d },
            { 6320000.0d, 0.000125487d },
            { 6358000.0d, 0.000124561d },
            { 6396000.0d, 0.000123616d },
            { 6434000.0d, 0.000122651d },
            { 6472000.0d, 0.000121668d },
            { 6510000.0d, 0.000120666d },
            { 6548000.0d, 0.000119646d },
            { 6586000.0d, 0.000118607d },
            { 6624000.0d, 0.000117551d },
            { 6662000.0d, 0.000116477d },
            { 6700000.0d, 0.000115386d },
            { 6738000.0d, 0.000114278d },
            { 6776000.0d, 0.000113154d },
            { 6814000.0d, 0.000112015d },
            { 6852000.0d, 0.00011086d },
            { 6890000.0d, 0.00010969d },
            { 6928000.0d, 0.000108506d },
            { 6966000.0d, 0.000107307d },
            { 7004000.0d, 0.000106095d },
            { 7042000.0d, 0.000104871d },
            { 7080000.0d, 0.000103633d },
            { 7118000.0d, 0.000102384d },
            { 7156000.0d, 0.000101122d },
            { 7194000.0d, 0.0000998498d },
            { 7232000.0d, 0.0000985666d },
            { 7270000.0d, 0.0000972733d },
            { 7308000.0d, 0.0000959701d },
            { 7346000.0d, 0.0000946578d },
            { 7384000.0d, 0.0000933371d },
            { 7422000.0d, 0.0000920082d },
            { 7460000.0d, 0.0000906719d },
            { 7498000.0d, 0.0000893286d },
            { 7536000.0d, 0.000087979d },
            { 7574000.0d, 0.0000866236d },
            { 7612000.0d, 0.000085263d },
            { 7650000.0d, 0.0000838979d },
            { 7688000.0d, 0.0000825287d },
            { 7726000.0d, 0.0000811561d },
            { 7764000.0d, 0.000079781d },
            { 7802000.0d, 0.0000784036d },
            { 7840000.0d, 0.0000770247d },
            { 7878000.0d, 0.000075645d },
            { 7916000.0d, 0.0000742651d },
            { 7954000.0d, 0.0000728856d },
            { 7992000.0d, 0.0000715072d },
            { 8030000.0d, 0.0000701306d },
            { 8068000.0d, 0.0000687566d },
            { 8106000.0d, 0.0000673856d },
            { 8144000.0d, 0.0000660185d },
            { 8182000.0d, 0.0000646559d },
            { 8220000.0d, 0.0000632986d },
            { 8258000.0d, 0.0000619472d },
            { 8296000.0d, 0.0000606026d },
            { 8334000.0d, 0.0000592653d },
            { 8372000.0d, 0.0000579363d },
            { 8410000.0d, 0.000056616d },
            { 8448000.0d, 0.0000553055d },
            { 8486000.0d, 0.0000540053d },
            { 8524000.0d, 0.0000527164d },
            { 8562000.0d, 0.0000514394d },
            { 8600000.0d, 0.000050175d },
            { 8638000.0d, 0.0000489241d },
            { 8676000.0d, 0.0000476876d },
            { 8714000.0d, 0.0000464661d },
            { 8752000.0d, 0.0000452606d },
            { 8790000.0d, 0.0000440717d },
            { 8828000.0d, 0.0000429003d },
            { 8866000.0d, 0.0000417473d },
            { 8904000.0d, 0.0000406134d },
            { 8942000.0d, 0.0000394995d },
            { 8980000.0d, 0.0000384065d },
            { 9018000.0d, 0.000037335d },
            { 9056000.0d, 0.0000362861d },
            { 9094000.0d, 0.0000352605d },
            { 9132000.0d, 0.0000342592d },
            { 9170000.0d, 0.0000332828d },
            { 9208000.0d, 0.0000323324d },
            { 9246000.0d, 0.0000314087d },
            { 9284000.0d, 0.0000305125d },
            { 9322000.0d, 0.0000296448d },
            { 9360000.0d, 0.0000288061d },
            { 9398000.0d, 0.0000279954d },
            { 9436000.0d, 0.0000271941d },
            { 9474000.0d, 0.0000263971d },
            { 9512000.0d, 0.0000256047d },
            { 9550000.0d, 0.0000248173d },
            { 9588000.0d, 0.0000240352d },
            { 9626000.0d, 0.0000232587d },
            { 9664000.0d, 0.0000224883d },
            { 9702000.0d, 0.0000217241d },
            { 9740000.0d, 0.0000209667d },
            { 9778000.0d, 0.0000202164d },
            { 9816000.0d, 0.0000194734d },
            { 9854000.0d, 0.0000187382d },
            { 9892000.0d, 0.0000180111d },
            { 9930000.0d, 0.0000172925d },
            { 9968000.0d, 0.0000165829d },
            { 10006000.0d, 0.0000158824d },
            { 10044000.0d, 0.0000151916d },
            { 10082000.0d, 0.0000145108d },
            { 10120000.0d, 0.0000138403d },
            { 10158000.0d, 0.0000131806d },
            { 10196000.0d, 0.000012532d },
            { 10234000.0d, 0.000011895d },
            { 10272000.0d, 0.0000112698d },
            { 10310000.0d, 0.000010657d },
            { 10348000.0d, 0.0000100569d },
            { 10386000.0d, 0.0000094699d },
            { 10424000.0d, 0.00000889638d },
            { 10462000.0d, 0.00000833676d },
            { 10500000.0d, 0.00000779146d },
            { 10538000.0d, 0.00000726087d },
            { 10576000.0d, 0.00000674541d },
            { 10614000.0d, 0.00000624548d },
            { 10652000.0d, 0.00000576149d },
            { 10690000.0d, 0.00000529388d },
            { 10728000.0d, 0.00000484305d },
            { 10766000.0d, 0.00000440942d },
            { 10804000.0d, 0.00000399341d },
            { 10842000.0d, 0.00000359544d },
            { 10880000.0d, 0.00000321596d },
            { 10918000.0d, 0.00000285537d },
            { 10956000.0d, 0.00000251409d },
            { 10994000.0d, 0.00000219258d },
            { 11032000.0d, 0.00000189125d },
            { 11070000.0d, 0.00000161052d },
            { 11108000.0d, 0.00000135084d },
            { 11146000.0d, 0.00000111263d },
            { 11184000.0d, 0.000000896319d },
            { 11222000.0d, 0.000000702326d },
            { 11260000.0d, 0.00000053108d },
            { 11298000.0d, 0.000000382999d },
            { 11336000.0d, 0.000000258493d },
            { 11374000.0d, 0.000000157964d },
            { 11412000.0d, 0.000000081794d },
            { 11450000.0d, 0.0000000303347d },
            { 11488000.0d, 0.00000000386146d },
            { 11509240.0d, 0d },

        }; 
    }
}
    