using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen19 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen19";
        public override double halfLife { get; } = 0.336d;
        public override double atomicWeight { get; } = 19.01702d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen19()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.474d, new GammaParticle(96400.0, 0.01286)), new(0.172d, new GammaParticle(1375700.0, 0.0009)), new(0.156d, new GammaParticle(2475200.0, 0.0005)), new(0.081d, new GammaParticle(3139000.0, 0.00039)), new(0.22d, new GammaParticle(3851000.0, 0.00032)), new(0.034d, new GammaParticle(3947000.0, 0.00031)) } },
            { 0.418d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen19()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.474d, new GammaParticle(96400.0, 0.01286)), new(0.172d, new GammaParticle(1375700.0, 0.0009)), new(0.156d, new GammaParticle(2475200.0, 0.0005)), new(0.081d, new GammaParticle(3139000.0, 0.00039)), new(0.22d, new GammaParticle(3851000.0, 0.00032)), new(0.034d, new GammaParticle(3947000.0, 0.00031)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000722149d },
            { 6000.0d, 0.00000822573d },
            { 12000.0d, 0.00000918323d },
            { 18000.0d, 0.000010094d },
            { 24000.0d, 0.0000109624d },
            { 30000.0d, 0.0000117928d },
            { 36000.0d, 0.0000125881d },
            { 42000.0d, 0.0000133591d },
            { 48000.0d, 0.0000141041d },
            { 54000.0d, 0.0000148284d },
            { 60000.0d, 0.0000155393d },
            { 66000.0d, 0.000016237d },
            { 72000.0d, 0.0000169206d },
            { 78000.0d, 0.000017595d },
            { 84000.0d, 0.0000182595d },
            { 90000.0d, 0.0000189203d },
            { 96000.0d, 0.0000195761d },
            { 102000.0d, 0.0000202264d },
            { 112000.0d, 0.0000212995d },
            { 122000.0d, 0.0000223653d },
            { 132000.0d, 0.0000234242d },
            { 142000.0d, 0.0000244772d },
            { 152000.0d, 0.0000255267d },
            { 162000.0d, 0.0000265725d },
            { 172000.0d, 0.0000276163d },
            { 182000.0d, 0.0000286584d },
            { 192000.0d, 0.0000296993d },
            { 202000.0d, 0.0000307394d },
            { 212000.0d, 0.0000317792d },
            { 222000.0d, 0.0000328188d },
            { 232000.0d, 0.0000338586d },
            { 242000.0d, 0.0000348986d },
            { 252000.0d, 0.000035939d },
            { 262000.0d, 0.00003698d },
            { 272000.0d, 0.0000380215d },
            { 282000.0d, 0.0000390636d },
            { 292000.0d, 0.0000401063d },
            { 302000.0d, 0.0000411497d },
            { 312000.0d, 0.0000421938d },
            { 322000.0d, 0.0000432385d },
            { 332000.0d, 0.0000442838d },
            { 342000.0d, 0.0000453296d },
            { 352000.0d, 0.000046376d },
            { 362000.0d, 0.0000474228d },
            { 372000.0d, 0.0000484699d },
            { 382000.0d, 0.0000495174d },
            { 392000.0d, 0.0000505651d },
            { 402000.0d, 0.0000516129d },
            { 412000.0d, 0.0000526608d },
            { 422000.0d, 0.0000537086d },
            { 432000.0d, 0.0000547564d },
            { 442000.0d, 0.0000558039d },
            { 452000.0d, 0.0000568512d },
            { 462000.0d, 0.000057898d },
            { 472000.0d, 0.0000589443d },
            { 482000.0d, 0.00005999d },
            { 492000.0d, 0.0000610351d },
            { 502000.0d, 0.0000620794d },
            { 512000.0d, 0.0000631227d },
            { 522000.0d, 0.0000641651d },
            { 532000.0d, 0.0000652063d },
            { 542000.0d, 0.0000662465d },
            { 552000.0d, 0.0000672852d },
            { 562000.0d, 0.0000683226d },
            { 572000.0d, 0.0000693584d },
            { 582000.0d, 0.0000703927d },
            { 592000.0d, 0.0000714253d },
            { 602000.0d, 0.0000724562d },
            { 612000.0d, 0.0000734852d },
            { 622000.0d, 0.0000745121d },
            { 632000.0d, 0.000075537d },
            { 642000.0d, 0.0000765597d },
            { 652000.0d, 0.0000775801d },
            { 662000.0d, 0.0000785982d },
            { 672000.0d, 0.0000796139d },
            { 682000.0d, 0.000080627d },
            { 692000.0d, 0.0000816375d },
            { 702000.0d, 0.0000826453d },
            { 712000.0d, 0.0000836503d },
            { 722000.0d, 0.0000846525d },
            { 732000.0d, 0.0000856518d },
            { 742000.0d, 0.0000866477d },
            { 752000.0d, 0.0000876408d },
            { 762000.0d, 0.0000886306d },
            { 772000.0d, 0.0000896171d },
            { 782000.0d, 0.0000906003d },
            { 792000.0d, 0.0000915801d },
            { 802000.0d, 0.0000925563d },
            { 812000.0d, 0.0000935291d },
            { 822000.0d, 0.000094498d },
            { 832000.0d, 0.0000954633d },
            { 842000.0d, 0.0000964248d },
            { 852000.0d, 0.0000973824d },
            { 862000.0d, 0.0000983362d },
            { 872000.0d, 0.000099286d },
            { 882000.0d, 0.000100232d },
            { 892000.0d, 0.000101173d },
            { 902000.0d, 0.000102111d },
            { 912000.0d, 0.000103044d },
            { 922000.0d, 0.000103973d },
            { 932000.0d, 0.000104898d },
            { 942000.0d, 0.000105819d },
            { 952000.0d, 0.000106734d },
            { 962000.0d, 0.000107646d },
            { 972000.0d, 0.000108553d },
            { 982000.0d, 0.000109455d },
            { 992000.0d, 0.000110353d },
            { 1002000.0d, 0.000111246d },
            { 1043000.0d, 0.000114859d },
            { 1084000.0d, 0.000118391d },
            { 1125000.0d, 0.00012184d },
            { 1166000.0d, 0.000125204d },
            { 1207000.0d, 0.000128483d },
            { 1248000.0d, 0.000131675d },
            { 1289000.0d, 0.000134782d },
            { 1330000.0d, 0.000137802d },
            { 1371000.0d, 0.000140738d },
            { 1412000.0d, 0.000143591d },
            { 1453000.0d, 0.000146361d },
            { 1494000.0d, 0.000149053d },
            { 1535000.0d, 0.000151667d },
            { 1576000.0d, 0.000154209d },
            { 1617000.0d, 0.000156681d },
            { 1658000.0d, 0.000159087d },
            { 1699000.0d, 0.000161433d },
            { 1740000.0d, 0.000163724d },
            { 1781000.0d, 0.000165965d },
            { 1822000.0d, 0.000168161d },
            { 1863000.0d, 0.00017032d },
            { 1904000.0d, 0.000172449d },
            { 1945000.0d, 0.000174554d },
            { 1986000.0d, 0.000176624d },
            { 2027000.0d, 0.000178595d },
            { 2068000.0d, 0.000180459d },
            { 2109000.0d, 0.000182217d },
            { 2150000.0d, 0.000183868d },
            { 2191000.0d, 0.000185412d },
            { 2232000.0d, 0.000186849d },
            { 2273000.0d, 0.000188178d },
            { 2314000.0d, 0.000189401d },
            { 2355000.0d, 0.000190518d },
            { 2396000.0d, 0.000191529d },
            { 2437000.0d, 0.000192436d },
            { 2478000.0d, 0.000193239d },
            { 2519000.0d, 0.000193939d },
            { 2560000.0d, 0.000194539d },
            { 2601000.0d, 0.000195039d },
            { 2642000.0d, 0.000195441d },
            { 2683000.0d, 0.000195748d },
            { 2724000.0d, 0.00019596d },
            { 2765000.0d, 0.000196081d },
            { 2806000.0d, 0.000196112d },
            { 2847000.0d, 0.000196057d },
            { 2888000.0d, 0.000195918d },
            { 2929000.0d, 0.000195697d },
            { 2970000.0d, 0.000195399d },
            { 3011000.0d, 0.000195025d },
            { 3052000.0d, 0.00019458d },
            { 3093000.0d, 0.000194067d },
            { 3134000.0d, 0.00019349d },
            { 3175000.0d, 0.000192852d },
            { 3216000.0d, 0.000192158d },
            { 3257000.0d, 0.000191411d },
            { 3298000.0d, 0.000190617d },
            { 3339000.0d, 0.00018978d },
            { 3380000.0d, 0.000188903d },
            { 3421000.0d, 0.000187993d },
            { 3462000.0d, 0.000187054d },
            { 3503000.0d, 0.000186092d },
            { 3544000.0d, 0.00018511d },
            { 3585000.0d, 0.000184116d },
            { 3626000.0d, 0.000183114d },
            { 3667000.0d, 0.00018211d },
            { 3708000.0d, 0.00018111d },
            { 3749000.0d, 0.00018012d },
            { 3790000.0d, 0.000179145d },
            { 3831000.0d, 0.000178149d },
            { 3872000.0d, 0.000177091d },
            { 3913000.0d, 0.000175972d },
            { 3954000.0d, 0.000174793d },
            { 3995000.0d, 0.000173557d },
            { 4036000.0d, 0.000172266d },
            { 4077000.0d, 0.000170921d },
            { 4118000.0d, 0.000169524d },
            { 4159000.0d, 0.000168079d },
            { 4200000.0d, 0.000166586d },
            { 4241000.0d, 0.000165049d },
            { 4282000.0d, 0.000163469d },
            { 4323000.0d, 0.000161849d },
            { 4364000.0d, 0.000160191d },
            { 4405000.0d, 0.000158499d },
            { 4446000.0d, 0.000156774d },
            { 4487000.0d, 0.000155019d },
            { 4528000.0d, 0.000153238d },
            { 4569000.0d, 0.000151432d },
            { 4610000.0d, 0.000149605d },
            { 4651000.0d, 0.000147759d },
            { 4692000.0d, 0.000145899d },
            { 4733000.0d, 0.000144026d },
            { 4774000.0d, 0.000142144d },
            { 4815000.0d, 0.000140257d },
            { 4856000.0d, 0.000138367d },
            { 4897000.0d, 0.000136478d },
            { 4938000.0d, 0.000134593d },
            { 4979000.0d, 0.000132716d },
            { 5020000.0d, 0.00013085d },
            { 5061000.0d, 0.000128999d },
            { 5102000.0d, 0.000127166d },
            { 5143000.0d, 0.000125356d },
            { 5184000.0d, 0.000123572d },
            { 5225000.0d, 0.000121817d },
            { 5266000.0d, 0.000120097d },
            { 5307000.0d, 0.000118414d },
            { 5348000.0d, 0.000116772d },
            { 5389000.0d, 0.000115176d },
            { 5430000.0d, 0.000113629d },
            { 5471000.0d, 0.000112136d },
            { 5512000.0d, 0.000110676d },
            { 5553000.0d, 0.000109198d },
            { 5594000.0d, 0.000107702d },
            { 5635000.0d, 0.000106187d },
            { 5676000.0d, 0.000104656d },
            { 5717000.0d, 0.000103109d },
            { 5758000.0d, 0.000101548d },
            { 5799000.0d, 0.0000999744d },
            { 5840000.0d, 0.0000983894d },
            { 5881000.0d, 0.0000967942d },
            { 5922000.0d, 0.0000951902d },
            { 5963000.0d, 0.0000935789d },
            { 6004000.0d, 0.0000919616d },
            { 6045000.0d, 0.0000903396d },
            { 6086000.0d, 0.0000887145d },
            { 6127000.0d, 0.0000870877d },
            { 6168000.0d, 0.0000854542d },
            { 6209000.0d, 0.0000838078d },
            { 6250000.0d, 0.0000821496d },
            { 6291000.0d, 0.0000804806d },
            { 6332000.0d, 0.0000788019d },
            { 6373000.0d, 0.0000771147d },
            { 6414000.0d, 0.0000754202d },
            { 6455000.0d, 0.0000737193d },
            { 6496000.0d, 0.0000720133d },
            { 6537000.0d, 0.0000703034d },
            { 6578000.0d, 0.0000685909d },
            { 6619000.0d, 0.0000668768d },
            { 6660000.0d, 0.0000651626d },
            { 6701000.0d, 0.0000634494d },
            { 6742000.0d, 0.0000617385d },
            { 6783000.0d, 0.0000600312d },
            { 6824000.0d, 0.0000583289d },
            { 6865000.0d, 0.0000566328d },
            { 6906000.0d, 0.0000549442d },
            { 6947000.0d, 0.0000532647d },
            { 6988000.0d, 0.0000515955d },
            { 7029000.0d, 0.0000499381d },
            { 7070000.0d, 0.0000482939d },
            { 7111000.0d, 0.0000466643d },
            { 7152000.0d, 0.0000450507d },
            { 7193000.0d, 0.0000434547d },
            { 7234000.0d, 0.0000418777d },
            { 7275000.0d, 0.0000403212d },
            { 7316000.0d, 0.0000387868d },
            { 7357000.0d, 0.0000372759d },
            { 7398000.0d, 0.0000357903d },
            { 7439000.0d, 0.0000343313d },
            { 7480000.0d, 0.0000329006d },
            { 7521000.0d, 0.0000314998d },
            { 7562000.0d, 0.0000301305d },
            { 7603000.0d, 0.0000287945d },
            { 7644000.0d, 0.0000274931d },
            { 7685000.0d, 0.0000262283d },
            { 7726000.0d, 0.0000250015d },
            { 7767000.0d, 0.0000238147d },
            { 7808000.0d, 0.0000226694d },
            { 7849000.0d, 0.0000215673d },
            { 7890000.0d, 0.0000205101d },
            { 7931000.0d, 0.0000194998d },
            { 7972000.0d, 0.0000185378d },
            { 8013000.0d, 0.0000176261d },
            { 8054000.0d, 0.0000167663d },
            { 8095000.0d, 0.00001596d },
            { 8136000.0d, 0.000015203d },
            { 8177000.0d, 0.0000144873d },
            { 8218000.0d, 0.0000138143d },
            { 8259000.0d, 0.0000131852d },
            { 8300000.0d, 0.0000126016d },
            { 8341000.0d, 0.0000120649d },
            { 8382000.0d, 0.0000115765d },
            { 8423000.0d, 0.0000111377d },
            { 8464000.0d, 0.00001075d },
            { 8505000.0d, 0.0000104148d },
            { 8546000.0d, 0.0000101331d },
            { 8587000.0d, 0.00000990608d },
            { 8628000.0d, 0.00000970485d },
            { 8669000.0d, 0.00000950782d },
            { 8710000.0d, 0.0000093152d },
            { 8751000.0d, 0.0000091272d },
            { 8792000.0d, 0.00000894395d },
            { 8833000.0d, 0.00000876569d },
            { 8874000.0d, 0.00000859259d },
            { 8915000.0d, 0.00000842486d },
            { 8956000.0d, 0.00000826268d },
            { 8997000.0d, 0.00000810624d },
            { 9038000.0d, 0.00000795576d },
            { 9079000.0d, 0.00000781142d },
            { 9120000.0d, 0.00000767342d },
            { 9161000.0d, 0.00000754196d },
            { 9202000.0d, 0.00000741722d },
            { 9243000.0d, 0.00000729938d },
            { 9284000.0d, 0.0000071886d },
            { 9325000.0d, 0.00000708295d },
            { 9366000.0d, 0.00000697677d },
            { 9407000.0d, 0.00000686977d },
            { 9448000.0d, 0.00000676197d },
            { 9489000.0d, 0.0000066534d },
            { 9530000.0d, 0.0000065441d },
            { 9571000.0d, 0.00000643407d },
            { 9612000.0d, 0.00000632336d },
            { 9653000.0d, 0.00000621201d },
            { 9694000.0d, 0.00000610004d },
            { 9735000.0d, 0.00000598749d },
            { 9776000.0d, 0.0000058744d },
            { 9817000.0d, 0.0000057608d },
            { 9858000.0d, 0.00000564674d },
            { 9899000.0d, 0.00000553225d },
            { 9940000.0d, 0.00000541738d },
            { 9981000.0d, 0.00000530218d },
            { 10022000.0d, 0.00000518668d },
            { 10063000.0d, 0.00000507095d },
            { 10104000.0d, 0.00000495501d },
            { 10145000.0d, 0.00000483894d },
            { 10186000.0d, 0.00000472277d },
            { 10227000.0d, 0.00000460658d },
            { 10268000.0d, 0.0000044904d },
            { 10309000.0d, 0.00000437431d },
            { 10350000.0d, 0.00000425836d },
            { 10391000.0d, 0.00000414262d },
            { 10432000.0d, 0.00000402714d },
            { 10473000.0d, 0.00000391201d },
            { 10514000.0d, 0.00000379727d },
            { 10555000.0d, 0.00000368301d },
            { 10596000.0d, 0.00000356931d },
            { 10637000.0d, 0.00000345623d },
            { 10678000.0d, 0.00000334385d },
            { 10719000.0d, 0.00000323225d },
            { 10760000.0d, 0.00000312151d },
            { 10801000.0d, 0.00000301172d },
            { 10842000.0d, 0.00000290297d },
            { 10883000.0d, 0.00000279534d },
            { 10924000.0d, 0.00000268891d },
            { 10965000.0d, 0.00000258379d },
            { 11006000.0d, 0.00000248007d },
            { 11047000.0d, 0.00000237784d },
            { 11088000.0d, 0.00000227697d },
            { 11129000.0d, 0.00000217684d },
            { 11170000.0d, 0.00000207751d },
            { 11211000.0d, 0.00000197907d },
            { 11252000.0d, 0.00000188161d },
            { 11293000.0d, 0.00000178523d },
            { 11334000.0d, 0.00000169002d },
            { 11375000.0d, 0.0000015961d },
            { 11416000.0d, 0.00000150356d },
            { 11457000.0d, 0.00000141252d },
            { 11498000.0d, 0.00000132309d },
            { 11539000.0d, 0.00000123537d },
            { 11580000.0d, 0.00000114949d },
            { 11621000.0d, 0.00000106557d },
            { 11662000.0d, 0.000000983735d },
            { 11703000.0d, 0.000000904114d },
            { 11744000.0d, 0.000000826831d },
            { 11785000.0d, 0.000000752023d },
            { 11826000.0d, 0.000000679827d },
            { 11867000.0d, 0.000000610382d },
            { 11908000.0d, 0.000000543833d },
            { 11949000.0d, 0.000000480326d },
            { 11990000.0d, 0.00000042001d },
            { 12031000.0d, 0.000000363041d },
            { 12072000.0d, 0.000000309573d },
            { 12113000.0d, 0.000000259767d },
            { 12154000.0d, 0.000000213786d },
            { 12195000.0d, 0.000000171795d },
            { 12236000.0d, 0.000000133964d },
            { 12277000.0d, 0.000000100464d },
            { 12318000.0d, 0.0000000714674d },
            { 12359000.0d, 0.0000000471506d },
            { 12400000.0d, 0.0000000276889d },
            { 12441000.0d, 0.0000000132565d },
            { 12482000.0d, 0.00000000402187d },
            { 12523000.0d, 0.000000000129097d },
            { 12532000.0d, 0d },

        }; 
    }
}
    