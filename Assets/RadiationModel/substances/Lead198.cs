using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead198 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead198";
        public override double halfLife { get; } = 8640.0d;
        public override double atomicWeight { get; } = 197.97202d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury198()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0007643999999999999d, new GammaParticle(30800.0, 0.04025)), new(7.28e-05d, new GammaParticle(107300.0, 0.01155)), new(0.01183d, new GammaParticle(116900.0, 0.01061)), new(0.0011466d, new GammaParticle(122600.0, 0.01011)), new(0.001456d, new GammaParticle(138300.0, 0.00896)), new(0.182d, new GammaParticle(173400.0, 0.00715)), new(0.00041860000000000004d, new GammaParticle(216500.0, 0.00573)), new(0.05824d, new GammaParticle(259500.0, 0.00478)), new(0.008736d, new GammaParticle(266700.0, 0.00465)), new(0.0027300000000000002d, new GammaParticle(275400.0, 0.0045)), new(0.364d, new GammaParticle(290300.0, 0.00427)), new(0.19474d, new GammaParticle(365400.0, 0.00339)), new(0.056420000000000005d, new GammaParticle(382000.0, 0.00325)), new(0.002184d, new GammaParticle(396500.0, 0.00313)), new(0.02912d, new GammaParticle(397700.0, 0.00312)), new(0.00728d, new GammaParticle(467800.0, 0.00265)), new(0.03094d, new GammaParticle(575000.0, 0.00216)), new(0.005642d, new GammaParticle(605900.0, 0.00205)), new(0.0182d, new GammaParticle(649000.0, 0.00191)), new(0.014742d, new GammaParticle(743000.0, 0.00167)), new(0.06006d, new GammaParticle(865300.0, 0.00143)), new(0.4083846486442808d, new GammaParticle(12148.0, 0.10206)), new(0.2843534342955715d, new GammaParticle(70832.0, 0.0175)), new(0.48000242116065406d, new GammaParticle(72874.0, 0.01701)), new(0.16324330914523863d, new GammaParticle(82629.0, 0.015)), new(0.2117265719613745d, new GammaParticle(83631.0, 0.01483)), new(0.04848326281613588d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000000000112676d },
            { 200.0d, 0.00000000000024351d },
            { 300.0d, 0.000000000000393285d },
            { 400.0d, 0.000000000000562065d },
            { 500.0d, 0.000000000000749876d },
            { 600.0d, 0.000000000000956733d },
            { 700.0d, 0.00000000000118265d },
            { 800.0d, 0.00000000000142762d },
            { 900.0d, 0.00000000000169168d },
            { 1000.0d, 0.00000000000197481d },
            { 1500.0d, 0.00000000000367737d },
            { 2000.0d, 0.00000000000609565d },
            { 2500.0d, 0.00000000000931291d },
            { 3000.0d, 0.0000000000135343d },
            { 3500.0d, 0.0000000000188399d },
            { 4000.0d, 0.0000000000253589d },
            { 4500.0d, 0.000000000033339d },
            { 5000.0d, 0.0000000000428068d },
            { 5500.0d, 0.0000000000539768d },
            { 6000.0d, 0.0000000000670098d },
            { 6500.0d, 0.0000000000819937d },
            { 7000.0d, 0.000000000099172d },
            { 7500.0d, 0.000000000118628d },
            { 8000.0d, 0.000000000140502d },
            { 8500.0d, 0.000000000165048d },
            { 9000.0d, 0.000000000192289d },
            { 9500.0d, 0.000000000222436d },
            { 10000.0d, 0.00000000025564d },
            { 10800.0d, 0.000000000315408d },
            { 11600.0d, 0.000000000383871d },
            { 12400.0d, 0.000000000461565d },
            { 13200.0d, 0.000000000549002d },
            { 14000.0d, 0.000000000646666d },
            { 14800.0d, 0.000000000755015d },
            { 15600.0d, 0.000000000874474d },
            { 16400.0d, 0.00000000100544d },
            { 17200.0d, 0.00000000114828d },
            { 18000.0d, 0.00000000130333d },
            { 18800.0d, 0.00000000147089d },
            { 19600.0d, 0.00000000165124d },
            { 20400.0d, 0.00000000184461d },
            { 21200.0d, 0.00000000205122d },
            { 22000.0d, 0.00000000227125d },
            { 22800.0d, 0.00000000250485d },
            { 23600.0d, 0.00000000275214d },
            { 24400.0d, 0.00000000301322d },
            { 25200.0d, 0.00000000328815d },
            { 26000.0d, 0.00000000357697d },
            { 26800.0d, 0.0000000038797d },
            { 27600.0d, 0.00000000419634d },
            { 28400.0d, 0.00000000452684d },
            { 29200.0d, 0.00000000487114d },
            { 30000.0d, 0.00000000522919d },
            { 30800.0d, 0.00000000560086d },
            { 31600.0d, 0.00000000598603d },
            { 32400.0d, 0.00000000638456d },
            { 33200.0d, 0.00000000679628d },
            { 34000.0d, 0.00000000722102d },
            { 34800.0d, 0.0000000076586d },
            { 35600.0d, 0.0000000081088d },
            { 36400.0d, 0.00000000857141d },
            { 37200.0d, 0.00000000904618d },
            { 38000.0d, 0.00000000953288d },
            { 38800.0d, 0.0000000100312d },
            { 39600.0d, 0.000000010541d },
            { 40400.0d, 0.0000000110618d },
            { 41200.0d, 0.0000000115935d },
            { 42000.0d, 0.0000000121356d },
            { 42800.0d, 0.0000000126881d },
            { 43600.0d, 0.0000000132504d },
            { 44400.0d, 0.0000000138223d },
            { 45200.0d, 0.0000000144035d },
            { 46000.0d, 0.0000000149936d },
            { 46800.0d, 0.0000000155922d },
            { 47600.0d, 0.0000000161991d },
            { 48400.0d, 0.0000000168139d },
            { 49200.0d, 0.0000000174363d },
            { 50000.0d, 0.0000000180659d },
            { 50800.0d, 0.0000000187023d },
            { 51600.0d, 0.0000000193452d },
            { 52400.0d, 0.000000019994d },
            { 53200.0d, 0.0000000206483d },
            { 54000.0d, 0.000000021308d },
            { 54800.0d, 0.0000000219726d },
            { 55600.0d, 0.0000000226417d },
            { 56400.0d, 0.0000000233149d },
            { 57200.0d, 0.000000023992d },
            { 58000.0d, 0.0000000246724d },
            { 58800.0d, 0.0000000253559d },
            { 59600.0d, 0.0000000260421d },
            { 60400.0d, 0.0000000267305d },
            { 61200.0d, 0.0000000274208d },
            { 62000.0d, 0.0000000281127d },
            { 62800.0d, 0.0000000288059d },
            { 63600.0d, 0.0000000294999d },
            { 64400.00000000001d, 0.0000000301944d },
            { 65200.0d, 0.0000000308891d },
            { 66000.0d, 0.0000000315836d },
            { 66800.0d, 0.0000000322775d },
            { 67600.0d, 0.0000000329705d },
            { 68400.0d, 0.0000000336624d },
            { 69200.0d, 0.0000000343526d },
            { 70000.0d, 0.000000035041d },
            { 70800.0d, 0.0000000357272d },
            { 71600.0d, 0.0000000364109d },
            { 72400.0d, 0.0000000370916d },
            { 73200.0d, 0.0000000377693d },
            { 74000.0d, 0.0000000384435d },
            { 74800.0d, 0.0000000391139d },
            { 75600.0d, 0.0000000397803d },
            { 76400.0d, 0.0000000404422d },
            { 77200.0d, 0.0000000410996d },
            { 78000.0d, 0.000000041752d },
            { 78800.0d, 0.0000000423993d },
            { 79600.0d, 0.000000043041d },
            { 80400.0d, 0.000000043677d },
            { 81200.0d, 0.0000000443071d },
            { 82000.0d, 0.0000000449308d },
            { 82800.0d, 0.000000045548d },
            { 83600.0d, 0.0000000461584d },
            { 84400.0d, 0.0000000467619d },
            { 85200.0d, 0.0000000473581d },
            { 86000.0d, 0.0000000479467d },
            { 86800.0d, 0.0000000485277d },
            { 87600.0d, 0.0000000491009d },
            { 88400.0d, 0.0000000496659d },
            { 89200.0d, 0.0000000502225d },
            { 90000.0d, 0.0000000507705d },
            { 90800.0d, 0.0000000513098d },
            { 91600.0d, 0.0000000518402d },
            { 92400.0d, 0.0000000523614d },
            { 93200.0d, 0.0000000528733d },
            { 94000.0d, 0.0000000533757d },
            { 94800.0d, 0.0000000538684d },
            { 95600.0d, 0.0000000543514d },
            { 96400.0d, 0.0000000548243d },
            { 97200.0d, 0.0000000552871d },
            { 98000.0d, 0.0000000557395d },
            { 98800.0d, 0.0000000561815d },
            { 99600.0d, 0.000000056613d },
            { 100400.0d, 0.0000000570337d },
            { 101200.0d, 0.0000000574435d },
            { 102000.0d, 0.0000000578424d },
            { 102800.0d, 0.0000000582302d },
            { 103600.0d, 0.0000000586067d },
            { 104400.0d, 0.0000000589719d },
            { 105200.0d, 0.0000000593257d },
            { 106000.0d, 0.0000000596679d },
            { 106800.0d, 0.0000000599985d },
            { 107600.0d, 0.0000000603174d },
            { 108400.0d, 0.0000000606245d },
            { 109200.0d, 0.0000000609197d },
            { 110000.0d, 0.0000000612029d },
            { 110800.0d, 0.0000000614741d },
            { 111600.0d, 0.0000000617332d },
            { 112400.0d, 0.0000000619801d },
            { 113200.0d, 0.0000000622148d },
            { 114000.0d, 0.0000000624372d },
            { 114800.0d, 0.0000000626473d },
            { 115600.0d, 0.000000062845d },
            { 116400.0d, 0.0000000630303d },
            { 117200.0d, 0.0000000632032d },
            { 118000.0d, 0.0000000633636d },
            { 118800.0d, 0.0000000635115d },
            { 119600.0d, 0.0000000636469d },
            { 120400.0d, 0.0000000637698d },
            { 121200.0d, 0.0000000638801d },
            { 122000.0d, 0.0000000639779d },
            { 122800.0d, 0.0000000640631d },
            { 123600.0d, 0.0000000641357d },
            { 124400.0d, 0.0000000641958d },
            { 125200.0d, 0.0000000642433d },
            { 126000.0d, 0.0000000642783d },
            { 126800.0d, 0.0000000643007d },
            { 127600.0d, 0.0000000643107d },
            { 128400.0d, 0.0000000643081d },
            { 129199.99999999999d, 0.0000000642932d },
            { 130000.0d, 0.0000000642658d },
            { 130800.00000000001d, 0.000000064226d },
            { 131600.0d, 0.0000000641739d },
            { 132400.0d, 0.0000000641094d },
            { 133200.0d, 0.0000000640328d },
            { 134000.0d, 0.0000000639439d },
            { 134800.0d, 0.0000000638429d },
            { 135600.0d, 0.0000000637298d },
            { 136400.0d, 0.0000000636047d },
            { 137200.0d, 0.0000000634675d },
            { 138000.0d, 0.0000000633185d },
            { 138800.0d, 0.0000000631577d },
            { 139600.0d, 0.0000000629851d },
            { 140400.0d, 0.0000000628008d },
            { 141200.0d, 0.000000062605d },
            { 142000.0d, 0.0000000623976d },
            { 142800.0d, 0.0000000621789d },
            { 143600.0d, 0.0000000619487d },
            { 144400.0d, 0.0000000617075d },
            { 145200.0d, 0.000000061455d },
            { 146000.0d, 0.0000000611915d },
            { 146800.0d, 0.0000000609171d },
            { 147600.0d, 0.0000000606319d },
            { 148400.0d, 0.000000060336d },
            { 149200.0d, 0.0000000600295d },
            { 150000.0d, 0.0000000597125d },
            { 150800.0d, 0.0000000593852d },
            { 151600.0d, 0.0000000590476d },
            { 152400.0d, 0.0000000586999d },
            { 153200.0d, 0.0000000583423d },
            { 154000.0d, 0.0000000579748d },
            { 154800.0d, 0.0000000575976d },
            { 155600.0d, 0.0000000572108d },
            { 156400.0d, 0.0000000568146d },
            { 157200.0d, 0.0000000564091d },
            { 158000.0d, 0.0000000559944d },
            { 158800.0d, 0.0000000555708d },
            { 159600.0d, 0.0000000551384d },
            { 160400.0d, 0.0000000546972d },
            { 161200.0d, 0.0000000542475d },
            { 162000.0d, 0.0000000537894d },
            { 162800.0d, 0.0000000533231d },
            { 163600.0d, 0.0000000528488d },
            { 164400.0d, 0.0000000523665d },
            { 165200.0d, 0.0000000518765d },
            { 166000.0d, 0.000000051379d },
            { 166800.0d, 0.0000000508741d },
            { 167600.0d, 0.0000000503621d },
            { 168400.0d, 0.000000049843d },
            { 169200.0d, 0.0000000493171d },
            { 170000.0d, 0.0000000487845d },
            { 170800.0d, 0.0000000482453d },
            { 171600.0d, 0.0000000476998d },
            { 172400.0d, 0.0000000471481d },
            { 173200.0d, 0.0000000465902d },
            { 174000.0d, 0.0000000460266d },
            { 174800.0d, 0.0000000454572d },
            { 175600.0d, 0.0000000448824d },
            { 176400.0d, 0.0000000443023d },
            { 177200.0d, 0.0000000437171d },
            { 178000.0d, 0.0000000431271d },
            { 178800.0d, 0.0000000425324d },
            { 179600.0d, 0.0000000419331d },
            { 180400.0d, 0.0000000413296d },
            { 181200.0d, 0.000000040722d },
            { 182000.0d, 0.0000000401107d },
            { 182800.0d, 0.0000000394956d },
            { 183600.0d, 0.0000000388771d },
            { 184400.0d, 0.0000000382554d },
            { 185200.0d, 0.0000000376307d },
            { 186000.0d, 0.0000000370032d },
            { 186800.0d, 0.0000000363732d },
            { 187600.0d, 0.0000000357408d },
            { 188400.0d, 0.0000000351063d },
            { 189200.0d, 0.0000000344699d },
            { 190000.0d, 0.0000000338319d },
            { 190800.0d, 0.0000000331924d },
            { 191600.0d, 0.0000000325517d },
            { 192400.0d, 0.0000000319101d },
            { 193200.0d, 0.0000000312677d },
            { 194000.0d, 0.0000000306248d },
            { 194800.0d, 0.0000000299817d },
            { 195600.0d, 0.0000000293385d },
            { 196400.0d, 0.0000000286956d },
            { 197200.0d, 0.0000000280531d },
            { 198000.0d, 0.0000000274113d },
            { 198800.0d, 0.0000000267705d },
            { 199600.0d, 0.0000000261309d },
            { 200400.0d, 0.0000000254927d },
            { 201200.0d, 0.0000000248562d },
            { 202000.0d, 0.0000000242216d },
            { 202800.0d, 0.0000000235893d },
            { 203600.0d, 0.0000000229594d },
            { 204400.0d, 0.0000000223323d },
            { 205200.0d, 0.000000021708d },
            { 206000.0d, 0.000000021087d },
            { 206800.0d, 0.0000000204695d },
            { 207600.0d, 0.0000000198557d },
            { 208400.0d, 0.0000000192461d },
            { 209200.0d, 0.0000000186405d },
            { 210000.0d, 0.0000000180396d },
            { 210800.0d, 0.0000000174435d },
            { 211600.0d, 0.0000000168524d },
            { 212400.0d, 0.0000000162667d },
            { 213200.0d, 0.0000000156866d },
            { 214000.0d, 0.0000000151125d },
            { 214800.0d, 0.0000000145444d },
            { 215600.0d, 0.0000000139827d },
            { 216400.0d, 0.0000000134278d },
            { 217200.0d, 0.00000001288d },
            { 218000.0d, 0.0000000123393d },
            { 218800.0d, 0.0000000118062d },
            { 219600.0d, 0.0000000112809d },
            { 220400.0d, 0.0000000107637d },
            { 221200.0d, 0.0000000102549d },
            { 222000.0d, 0.00000000975486d },
            { 222800.0d, 0.00000000926366d },
            { 223600.0d, 0.00000000878176d },
            { 224400.0d, 0.00000000830939d },
            { 225200.0d, 0.00000000784683d },
            { 226000.0d, 0.00000000739439d },
            { 226800.0d, 0.00000000695236d },
            { 227600.0d, 0.00000000652101d },
            { 228400.0d, 0.00000000610065d },
            { 229200.0d, 0.00000000569157d },
            { 230000.0d, 0.00000000529406d },
            { 230800.0d, 0.00000000490843d },
            { 231600.0d, 0.00000000453496d },
            { 232400.0d, 0.00000000417397d },
            { 233200.0d, 0.00000000382574d },
            { 234000.0d, 0.00000000349057d },
            { 234800.0d, 0.00000000316877d },
            { 235600.0d, 0.00000000286063d },
            { 236400.0d, 0.00000000256646d },
            { 237200.0d, 0.00000000228657d },
            { 238000.0d, 0.00000000202125d },
            { 238800.0d, 0.00000000177082d },
            { 239600.0d, 0.00000000153558d },
            { 240400.0d, 0.00000000131583d },
            { 241200.0d, 0.00000000111189d },
            { 242000.0d, 0.000000000924056d },
            { 242800.0d, 0.000000000752645d },
            { 243600.0d, 0.000000000597963d },
            { 244400.0d, 0.000000000460322d },
            { 245200.0d, 0.000000000340031d },
            { 246000.0d, 0.000000000237402d },
            { 246800.0d, 0.000000000152745d },
            { 247600.0d, 0.0000000000863709d },
            { 248400.0d, 0.0000000000385884d },
            { 249200.0d, 0.0000000000097049d },
            { 250000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    