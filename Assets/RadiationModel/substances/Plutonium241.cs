using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241";
        public override double halfLife { get; } = 452179192.28993d;
        public override double atomicWeight { get; } = 241.05685d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999800000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium241()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 2.47e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium237()), new(1.0d, new AlphaParticle(6162002.09)), new(4.165e-08d, new GammaParticle(44200.0, 0.02805)), new(8.33e-09d, new GammaParticle(44860.0, 0.02764)), new(2.499e-08d, new GammaParticle(56320.0, 0.02201)), new(9.8e-09d, new GammaParticle(56760.0, 0.02184)), new(2.87e-08d, new GammaParticle(71600.0, 0.01732)), new(2.06e-07d, new GammaParticle(77100.0, 0.01608)), new(7.109999999999999e-10d, new GammaParticle(101000.0, 0.01228)), new(1.012e-06d, new GammaParticle(103680.0, 0.01196)), new(8.100000000000001e-07d, new GammaParticle(114000.0, 0.01088)), new(6.86e-09d, new GammaParticle(121200.0, 0.01023)), new(1.86e-06d, new GammaParticle(148567.0, 0.00835)), new(6.54e-08d, new GammaParticle(159955.0, 0.00775)), new(1.24597035816e-05d, new GammaParticle(16678.0, 0.07434)), new(3.1785362468885805e-06d, new GammaParticle(94657.0, 0.0131)), new(5.088100283157644e-06d, new GammaParticle(98439.0, 0.0126)), new(1.8356614649432e-06d, new GammaParticle(111238.0, 0.01115)), new(2.4634576859537747e-06d, new GammaParticle(112645.0, 0.01101)), new(6.277962210105744e-07d, new GammaParticle(114446.0, 0.01083)) } },
            { 2.4e-16d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.155306d },
            { 60.0d, 0.154178d },
            { 120.0d, 0.153057d },
            { 180.0d, 0.151943d },
            { 240.0d, 0.150836d },
            { 300.0d, 0.149735d },
            { 360.0d, 0.148641d },
            { 420.0d, 0.147553d },
            { 480.0d, 0.146472d },
            { 540.0d, 0.145398d },
            { 600.0d, 0.14433d },
            { 660.0d, 0.143268d },
            { 720.0d, 0.142213d },
            { 780.0d, 0.141164d },
            { 840.0d, 0.140122d },
            { 900.0d, 0.139086d },
            { 960.0d, 0.138056d },
            { 1020.0d, 0.137032d },
            { 1080.0d, 0.136015d },
            { 1140.0d, 0.135003d },
            { 1200.0d, 0.133998d },
            { 1260.0d, 0.132999d },
            { 1320.0d, 0.132006d },
            { 1380.0d, 0.131019d },
            { 1440.0d, 0.130038d },
            { 1500.0d, 0.129063d },
            { 1560.0d, 0.128094d },
            { 1620.0d, 0.127131d },
            { 1680.0d, 0.126173d },
            { 1740.0d, 0.125222d },
            { 1800.0d, 0.124276d },
            { 1860.0d, 0.123336d },
            { 1920.0d, 0.122401d },
            { 1980.0d, 0.121473d },
            { 2040.0d, 0.12055d },
            { 2100.0d, 0.119632d },
            { 2160.0d, 0.118721d },
            { 2220.0d, 0.117814d },
            { 2280.0d, 0.116914d },
            { 2340.0d, 0.116019d },
            { 2400.0d, 0.115129d },
            { 2460.0d, 0.114244d },
            { 2520.0d, 0.113366d },
            { 2580.0d, 0.112492d },
            { 2640.0d, 0.111624d },
            { 2700.0d, 0.110761d },
            { 2760.0d, 0.109903d },
            { 2820.0d, 0.109051d },
            { 2880.0d, 0.108204d },
            { 2940.0d, 0.107362d },
            { 3000.0d, 0.106525d },
            { 3060.0d, 0.105693d },
            { 3120.0d, 0.104866d },
            { 3180.0d, 0.104045d },
            { 3240.0d, 0.103228d },
            { 3300.0d, 0.102417d },
            { 3360.0d, 0.10161d },
            { 3420.0d, 0.100808d },
            { 3480.0d, 0.100012d },
            { 3540.0d, 0.0992197d },
            { 3600.0d, 0.0984327d },
            { 3660.0d, 0.0976505d },
            { 3720.0d, 0.0968731d },
            { 3780.0d, 0.0961004d },
            { 3840.0d, 0.0953325d },
            { 3900.0d, 0.0945693d },
            { 3960.0d, 0.0938108d },
            { 4019.9999999999995d, 0.093057d },
            { 4080.0d, 0.0923077d },
            { 4140.0d, 0.0915631d },
            { 4200.0d, 0.090823d },
            { 4260.0d, 0.0900875d },
            { 4320.0d, 0.0893564d },
            { 4380.0d, 0.0886299d },
            { 4440.0d, 0.0879078d },
            { 4500.0d, 0.0871902d },
            { 4560.0d, 0.0864769d },
            { 4620.0d, 0.0857681d },
            { 4680.0d, 0.0850636d },
            { 4740.0d, 0.0843634d },
            { 4800.0d, 0.0836675d },
            { 4860.0d, 0.0829759d },
            { 4920.0d, 0.0822885d },
            { 4980.0d, 0.0816054d },
            { 5040.0d, 0.0809264d },
            { 5100.0d, 0.0802516d },
            { 5160.0d, 0.079581d },
            { 5220.0d, 0.0789145d },
            { 5280.0d, 0.078252d },
            { 5340.0d, 0.0775937d },
            { 5400.0d, 0.0769394d },
            { 5460.0d, 0.0762891d },
            { 5520.0d, 0.0756428d },
            { 5580.0d, 0.0750005d },
            { 5640.0d, 0.0743621d },
            { 5700.0d, 0.0737276d },
            { 5760.0d, 0.0730971d },
            { 5820.0d, 0.0724704d },
            { 5880.0d, 0.0718476d },
            { 5940.0d, 0.0712286d },
            { 6000.0d, 0.0706134d },
            { 6060.0d, 0.0700019d },
            { 6120.0d, 0.0693943d },
            { 6180.0d, 0.0687903d },
            { 6240.0d, 0.0681901d },
            { 6300.0d, 0.0675936d },
            { 6360.0d, 0.0670007d },
            { 6420.0d, 0.0664115d },
            { 6480.0d, 0.0658259d },
            { 6540.0d, 0.0652439d },
            { 6600.0d, 0.0646655d },
            { 6660.0d, 0.0640907d },
            { 6720.0d, 0.0635193d },
            { 6780.0d, 0.0629515d },
            { 6840.0d, 0.0623872d },
            { 6900.0d, 0.0618264d },
            { 6960.0d, 0.061269d },
            { 7020.0d, 0.060715d },
            { 7080.0d, 0.0601645d },
            { 7140.0d, 0.0596173d },
            { 7200.0d, 0.0590735d },
            { 7260.0d, 0.058533d },
            { 7320.0d, 0.0579959d },
            { 7380.0d, 0.0574621d },
            { 7440.0d, 0.0569315d },
            { 7500.0d, 0.0564043d },
            { 7560.0d, 0.0558803d },
            { 7620.0d, 0.0553595d },
            { 7680.0d, 0.0548419d },
            { 7740.0d, 0.0543275d },
            { 7800.0d, 0.0538163d },
            { 7860.0d, 0.0533082d },
            { 7920.0d, 0.0528033d },
            { 7980.0d, 0.0523015d },
            { 8039.999999999999d, 0.0518028d },
            { 8100.0d, 0.0513071d },
            { 8160.0d, 0.0508145d },
            { 8220.0d, 0.050325d },
            { 8280.0d, 0.0498385d },
            { 8340.0d, 0.049355d },
            { 8400.0d, 0.0488745d },
            { 8460.0d, 0.048397d },
            { 8520.0d, 0.0479224d },
            { 8580.0d, 0.0474507d },
            { 8640.0d, 0.046982d },
            { 8700.0d, 0.0465162d },
            { 8760.0d, 0.0460533d },
            { 8820.0d, 0.0455932d },
            { 8880.0d, 0.045136d },
            { 8940.0d, 0.0446817d },
            { 9000.0d, 0.0442301d },
            { 9060.0d, 0.0437814d },
            { 9120.0d, 0.0433355d },
            { 9180.0d, 0.0428924d },
            { 9240.0d, 0.042452d },
            { 9300.0d, 0.0420143d },
            { 9360.0d, 0.0415794d },
            { 9420.0d, 0.0411472d },
            { 9480.0d, 0.0407177d },
            { 9540.0d, 0.040291d },
            { 9600.0d, 0.0398668d },
            { 9660.0d, 0.0394454d },
            { 9720.0d, 0.0390266d },
            { 9780.0d, 0.0386104d },
            { 9840.0d, 0.0381968d },
            { 9900.0d, 0.0377858d },
            { 9960.0d, 0.0373775d },
            { 10000.0d, 0.0371067d },
            { 10060.0d, 0.0367026d },
            { 10120.0d, 0.036301d },
            { 10180.0d, 0.0359021d },
            { 10240.0d, 0.0355056d },
            { 10300.0d, 0.0351117d },
            { 10360.0d, 0.0347202d },
            { 10420.0d, 0.0343313d },
            { 10480.0d, 0.0339449d },
            { 10540.0d, 0.0335609d },
            { 10600.0d, 0.0331793d },
            { 10660.0d, 0.0328003d },
            { 10720.0d, 0.0324236d },
            { 10780.0d, 0.0320494d },
            { 10840.0d, 0.0316776d },
            { 10900.0d, 0.0313082d },
            { 10960.0d, 0.0309412d },
            { 11020.0d, 0.0305765d },
            { 11080.0d, 0.0302142d },
            { 11140.0d, 0.0298543d },
            { 11200.0d, 0.0294968d },
            { 11260.0d, 0.0291416d },
            { 11320.0d, 0.0287887d },
            { 11380.0d, 0.028438d },
            { 11440.0d, 0.0280898d },
            { 11500.0d, 0.0277438d },
            { 11560.0d, 0.0274001d },
            { 11620.0d, 0.0270587d },
            { 11680.0d, 0.0267196d },
            { 11740.0d, 0.0263828d },
            { 11800.0d, 0.0260482d },
            { 11860.0d, 0.0257158d },
            { 11920.0d, 0.0253857d },
            { 11980.0d, 0.0250577d },
            { 12040.0d, 0.024732d },
            { 12100.0d, 0.0244086d },
            { 12160.0d, 0.0240874d },
            { 12220.0d, 0.0237683d },
            { 12280.0d, 0.0234514d },
            { 12340.0d, 0.0231368d },
            { 12400.0d, 0.0228243d },
            { 12460.0d, 0.022514d },
            { 12520.0d, 0.0222058d },
            { 12580.0d, 0.0218997d },
            { 12640.0d, 0.0215959d },
            { 12700.0d, 0.0212942d },
            { 12760.0d, 0.0209946d },
            { 12820.0d, 0.0206972d },
            { 12880.0d, 0.0204019d },
            { 12940.0d, 0.0201087d },
            { 13000.0d, 0.0198176d },
            { 13060.0d, 0.0195286d },
            { 13120.0d, 0.0192417d },
            { 13180.0d, 0.0189569d },
            { 13240.0d, 0.0186743d },
            { 13300.0d, 0.0183937d },
            { 13360.0d, 0.0181152d },
            { 13420.0d, 0.0178388d },
            { 13480.0d, 0.0175645d },
            { 13540.0d, 0.0172922d },
            { 13600.0d, 0.017022d },
            { 13660.0d, 0.0167538d },
            { 13720.0d, 0.0164878d },
            { 13780.0d, 0.0162238d },
            { 13840.0d, 0.0159618d },
            { 13900.0d, 0.015702d },
            { 13960.0d, 0.0154441d },
            { 14020.0d, 0.0151883d },
            { 14080.0d, 0.0149345d },
            { 14140.0d, 0.0146828d },
            { 14200.0d, 0.0144332d },
            { 14260.0d, 0.0141856d },
            { 14320.0d, 0.01394d },
            { 14380.0d, 0.0136964d },
            { 14440.0d, 0.0134549d },
            { 14500.0d, 0.0132154d },
            { 14560.0d, 0.0129779d },
            { 14620.0d, 0.0127425d },
            { 14680.0d, 0.0125091d },
            { 14740.0d, 0.0122777d },
            { 14800.0d, 0.0120484d },
            { 14860.0d, 0.0118211d },
            { 14920.0d, 0.0115957d },
            { 14980.0d, 0.0113725d },
            { 15040.0d, 0.0111513d },
            { 15100.0d, 0.0109321d },
            { 15160.0d, 0.0107148d },
            { 15220.0d, 0.0104997d },
            { 15280.0d, 0.0102866d },
            { 15340.0d, 0.0100755d },
            { 15400.0d, 0.00986644d },
            { 15460.0d, 0.00965941d },
            { 15520.0d, 0.00945441d },
            { 15580.0d, 0.00925145d },
            { 15640.0d, 0.00905053d },
            { 15700.0d, 0.00885164d },
            { 15760.0d, 0.0086548d },
            { 15820.0d, 0.00846d },
            { 15880.0d, 0.00826725d },
            { 15940.0d, 0.00807655d },
            { 16000.0d, 0.0078879d },
            { 16059.999999999998d, 0.0077013d },
            { 16120.000000000002d, 0.00751676d },
            { 16180.0d, 0.00733428d },
            { 16239.999999999998d, 0.00715387d },
            { 16300.0d, 0.00697552d },
            { 16360.0d, 0.00679925d },
            { 16420.0d, 0.00662505d },
            { 16480.0d, 0.00645293d },
            { 16540.0d, 0.0062829d },
            { 16600.0d, 0.00611495d },
            { 16660.0d, 0.00594909d },
            { 16720.0d, 0.00578534d },
            { 16780.0d, 0.00562369d },
            { 16840.0d, 0.00546414d },
            { 16900.0d, 0.00530671d },
            { 16960.0d, 0.0051514d },
            { 17020.0d, 0.00499821d },
            { 17080.0d, 0.00484715d },
            { 17140.0d, 0.00469823d },
            { 17200.0d, 0.00455145d },
            { 17260.0d, 0.00440682d },
            { 17320.0d, 0.00426434d },
            { 17380.0d, 0.00412403d },
            { 17440.0d, 0.00398589d },
            { 17500.0d, 0.00384992d },
            { 17560.0d, 0.00371613d },
            { 17620.0d, 0.00358454d },
            { 17680.0d, 0.00345514d },
            { 17740.0d, 0.00332794d },
            { 17800.0d, 0.00320297d },
            { 17860.0d, 0.00308021d },
            { 17920.0d, 0.00295968d },
            { 17980.0d, 0.00284139d },
            { 18040.0d, 0.00272534d },
            { 18100.0d, 0.00261155d },
            { 18160.0d, 0.00250003d },
            { 18220.0d, 0.00239078d },
            { 18280.0d, 0.0022838d },
            { 18340.0d, 0.00217913d },
            { 18400.0d, 0.00207675d },
            { 18460.0d, 0.00197668d },
            { 18520.0d, 0.00187893d },
            { 18580.0d, 0.00178352d },
            { 18640.0d, 0.00169045d },
            { 18700.0d, 0.00159973d },
            { 18760.0d, 0.00151138d },
            { 18820.0d, 0.00142539d },
            { 18880.0d, 0.00134179d },
            { 18940.0d, 0.00126058d },
            { 19000.0d, 0.00118178d },
            { 19060.0d, 0.0011054d },
            { 19120.0d, 0.00103145d },
            { 19180.0d, 0.000959942d },
            { 19240.0d, 0.000890888d },
            { 19300.0d, 0.000824298d },
            { 19360.0d, 0.000760187d },
            { 19420.0d, 0.000698565d },
            { 19480.0d, 0.000639447d },
            { 19540.0d, 0.000582846d },
            { 19600.0d, 0.000528774d },
            { 19660.0d, 0.000477244d },
            { 19720.0d, 0.000428271d },
            { 19780.0d, 0.000381867d },
            { 19840.0d, 0.000338046d },
            { 19900.0d, 0.000296823d },
            { 19960.0d, 0.000258211d },
            { 20020.0d, 0.000222224d },
            { 20080.0d, 0.000188878d },
            { 20140.0d, 0.000158187d },
            { 20200.0d, 0.000130165d },
            { 20260.0d, 0.000104827d },
            { 20320.0d, 0.0000821896d },
            { 20380.0d, 0.0000622671d },
            { 20440.0d, 0.0000450752d },
            { 20500.0d, 0.0000306296d },
            { 20560.0d, 0.0000189463d },
            { 20620.0d, 0.0000100413d },
            { 20680.0d, 0.00000393067d },
            { 20740.0d, 0.000000631007d },
            { 20780.0d, 0d },

        }; 
    }
}
    