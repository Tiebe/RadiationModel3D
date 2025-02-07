using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold191 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold191";
        public override double halfLife { get; } = 11448.0d;
        public override double atomicWeight { get; } = 190.96372d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium191()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00026599999999999996d, new GammaParticle(24390.0, 0.05083)), new(0.0021d, new GammaParticle(30400.0, 0.04078)), new(0.00013440000000000001d, new GammaParticle(48370.0, 0.02563)), new(0.00266d, new GammaParticle(56780.0, 0.02184)), new(0.000616d, new GammaParticle(87740.0, 0.01413)), new(0.013859999999999999d, new GammaParticle(91110.0, 0.01361)), new(0.00042d, new GammaParticle(106360.0, 0.01166)), new(0.00042d, new GammaParticle(122710.0, 0.0101)), new(0.0011899999999999999d, new GammaParticle(126920.0, 0.00977)), new(0.00294d, new GammaParticle(132000.0, 0.00939)), new(0.01008d, new GammaParticle(132890.0, 0.00933)), new(0.0022400000000000002d, new GammaParticle(133700.0, 0.00927)), new(0.005600000000000001d, new GammaParticle(136090.0, 0.00911)), new(0.00196d, new GammaParticle(142510.0, 0.0087)), new(0.00084d, new GammaParticle(145950.0, 0.00849)), new(0.00714d, new GammaParticle(147490.0, 0.00841)), new(0.00406d, new GammaParticle(156970.0, 0.0079)), new(0.005600000000000001d, new GammaParticle(157330.0, 0.00788)), new(0.01218d, new GammaParticle(158860.0, 0.0078)), new(0.0273d, new GammaParticle(166500.0, 0.00745)), new(0.0021d, new GammaParticle(192820.0, 0.00643)), new(0.02254d, new GammaParticle(194140.0, 0.00639)), new(0.00084d, new GammaParticle(202430.0, 0.00612)), new(0.011479999999999999d, new GammaParticle(206390.0, 0.00601)), new(0.00672d, new GammaParticle(206390.0, 0.00601)), new(0.0049d, new GammaParticle(210090.0, 0.0059)), new(0.00182d, new GammaParticle(223630.0, 0.00554)), new(0.007980000000000001d, new GammaParticle(244380.0, 0.00507)), new(0.00616d, new GammaParticle(247500.0, 0.00501)), new(0.02086d, new GammaParticle(253950.0, 0.00488)), new(0.01274d, new GammaParticle(263090.0, 0.00471)), new(0.01624d, new GammaParticle(268330.0, 0.00462)), new(0.020720000000000002d, new GammaParticle(271650.0, 0.00456)), new(0.059359999999999996d, new GammaParticle(277860.0, 0.00446)), new(0.024220000000000002d, new GammaParticle(280400.0, 0.00442)), new(0.055439999999999996d, new GammaParticle(283900.0, 0.00437)), new(0.02338d, new GammaParticle(293450.0, 0.00423)), new(0.0007000000000000001d, new GammaParticle(316500.0, 0.00392)), new(0.00126d, new GammaParticle(332030.0, 0.00373)), new(0.00126d, new GammaParticle(340350.0, 0.00364)), new(0.0044800000000000005d, new GammaParticle(347540.0, 0.00357)), new(0.025619999999999997d, new GammaParticle(353880.0, 0.0035)), new(0.0014000000000000002d, new GammaParticle(359850.0, 0.00345)), new(0.00364d, new GammaParticle(368660.0, 0.00336)), new(0.0034999999999999996d, new GammaParticle(376560.0, 0.00329)), new(0.029679999999999998d, new GammaParticle(386900.0, 0.0032)), new(0.022400000000000003d, new GammaParticle(390250.0, 0.00318)), new(0.039060000000000004d, new GammaParticle(399840.0, 0.0031)), new(0.00756d, new GammaParticle(408210.0, 0.00304)), new(0.00364d, new GammaParticle(410200.0, 0.00302)), new(0.0021d, new GammaParticle(411500.0, 0.00301)), new(0.030379999999999997d, new GammaParticle(413760.0, 0.003)), new(0.02842d, new GammaParticle(421440.0, 0.00294)), new(0.00182d, new GammaParticle(427330.0, 0.0029)), new(0.00126d, new GammaParticle(432420.0, 0.00287)), new(0.0049d, new GammaParticle(442270.0, 0.0028)), new(0.00294d, new GammaParticle(446580.0, 0.00278)), new(0.00126d, new GammaParticle(450690.0, 0.00275)), new(0.01106d, new GammaParticle(451210.0, 0.00275)), new(0.01106d, new GammaParticle(451850.0, 0.00274)), new(0.00196d, new GammaParticle(460940.0, 0.00269)), new(0.00616d, new GammaParticle(467040.0, 0.00265)), new(0.03248d, new GammaParticle(478040.0, 0.00259)), new(0.02282d, new GammaParticle(487610.0, 0.00254)), new(0.0047599999999999995d, new GammaParticle(495740.0, 0.0025)), new(0.00378d, new GammaParticle(499620.0, 0.00248)), new(0.00714d, new GammaParticle(525790.0, 0.00236)), new(0.00322d, new GammaParticle(532630.0, 0.00233)), new(0.0011200000000000001d, new GammaParticle(535250.0, 0.00232)), new(0.00672d, new GammaParticle(538700.0, 0.0023)), new(0.00126d, new GammaParticle(544350.0, 0.00228)), new(0.00182d, new GammaParticle(557510.0, 0.00222)), new(0.0005600000000000001d, new GammaParticle(561720.0, 0.00221)), new(0.00406d, new GammaParticle(565130.0, 0.00219)), new(0.0014000000000000002d, new GammaParticle(568290.0, 0.00218)), new(0.0014000000000000002d, new GammaParticle(574540.0, 0.00216)), new(0.0007000000000000001d, new GammaParticle(580500.0, 0.00214)), new(0.14d, new GammaParticle(586440.0, 0.00211)), new(0.0028000000000000004d, new GammaParticle(595900.0, 0.00208)), new(0.00308d, new GammaParticle(616260.0, 0.00201)), new(0.008960000000000001d, new GammaParticle(620310.0, 0.002)), new(0.0074199999999999995d, new GammaParticle(625850.0, 0.00198)), new(0.00168d, new GammaParticle(627740.0, 0.00198)), new(0.00084d, new GammaParticle(647970.0, 0.00191)), new(0.0023799999999999997d, new GammaParticle(659690.0, 0.00188)), new(0.0005600000000000001d, new GammaParticle(669590.0, 0.00185)), new(0.056280000000000004d, new GammaParticle(674220.0, 0.00184)), new(0.0005600000000000001d, new GammaParticle(680740.0, 0.00182)), new(0.0044800000000000005d, new GammaParticle(701940.0, 0.00177)), new(0.00084d, new GammaParticle(732480.0, 0.00169)), new(0.0011200000000000001d, new GammaParticle(734370.0, 0.00169)), new(0.00168d, new GammaParticle(767750.0, 0.00161)), new(0.0021d, new GammaParticle(780510.0, 0.00159)), new(0.00588d, new GammaParticle(792780.0, 0.00156)), new(0.00294d, new GammaParticle(820070.0, 0.00151)), new(0.0005600000000000001d, new GammaParticle(829880.0, 0.00149)), new(0.005600000000000001d, new GammaParticle(835530.0, 0.00148)), new(0.0005600000000000001d, new GammaParticle(854280.0, 0.00145)), new(0.00252d, new GammaParticle(859570.0, 0.00144)), new(0.00084d, new GammaParticle(870540.0, 0.00142)), new(0.00154d, new GammaParticle(880770.0, 0.00141)), new(0.0011200000000000001d, new GammaParticle(896580.0, 0.00138)), new(0.0007000000000000001d, new GammaParticle(920810.0, 0.00135)), new(0.0005600000000000001d, new GammaParticle(1006300.0, 0.00123)), new(0.00084d, new GammaParticle(1023000.0, 0.00121)), new(0.00098d, new GammaParticle(1028000.0, 0.00121)), new(0.0007000000000000001d, new GammaParticle(1035800.0, 0.0012)), new(0.00126d, new GammaParticle(1064700.0, 0.00116)), new(0.0014000000000000002d, new GammaParticle(1074200.0, 0.00115)), new(0.0005600000000000001d, new GammaParticle(1086900.0, 0.00114)), new(0.00098d, new GammaParticle(1096800.0, 0.00113)), new(0.0011200000000000001d, new GammaParticle(1101900.0, 0.00113)), new(0.0021d, new GammaParticle(1113600.0, 0.00111)), new(0.00154d, new GammaParticle(1161200.0, 0.00107)), new(0.00168d, new GammaParticle(1164900.0, 0.00106)), new(0.0011200000000000001d, new GammaParticle(1174000.0, 0.00106)), new(0.00126d, new GammaParticle(1199300.0, 0.00103)), new(0.0023799999999999997d, new GammaParticle(1259600.0, 0.00098)), new(0.00126d, new GammaParticle(1302300.0, 0.00095)), new(0.005580000000000001d, new GammaParticle(511000.0, 0.00243)), new(0.42100000000000004d, new GammaParticle(11070.0, 0.112)), new(0.292d, new GammaParticle(65122.0, 0.01904)), new(0.499d, new GammaParticle(66832.0, 0.01855)), new(0.168d, new GammaParticle(75821.0, 0.01635)), new(0.21600000000000003d, new GammaParticle(76725.0, 0.01616)), new(0.048d, new GammaParticle(77832.0, 0.01593)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 400.0d, 7.31003e-18d },
            { 800.0d, 3.41318e-16d },
            { 1200.0d, 0.0000000000000585286d },
            { 1700.0d, 0.000000000000212255d },
            { 2200.0d, 0.00000000000348371d },
            { 2700.0d, 0.00000000000879007d },
            { 3200.0d, 0.0000000000160342d },
            { 3700.0d, 0.0000000000255944d },
            { 4200.0d, 0.0000000000413792d },
            { 4700.0d, 0.0000000000688444d },
            { 5200.0d, 0.000000000103718d },
            { 5700.0d, 0.0000000001467d },
            { 6200.0d, 0.000000000204301d },
            { 6700.0d, 0.000000000285617d },
            { 7200.0d, 0.000000000383349d },
            { 7700.0d, 0.000000000498399d },
            { 8200.0d, 0.000000000638951d },
            { 8700.0d, 0.000000000816442d },
            { 9200.0d, 0.00000000102163d },
            { 9700.0d, 0.00000000125557d },
            { 10000.0d, 0.00000000140952d },
            { 11000.0d, 0.00000000206075d },
            { 12000.0d, 0.00000000287419d },
            { 13000.0d, 0.00000000391476d },
            { 14000.0d, 0.00000000516689d },
            { 15000.0d, 0.00000000669343d },
            { 16000.0d, 0.00000000847888d },
            { 17000.0d, 0.0000000105806d },
            { 18000.0d, 0.0000000129847d },
            { 19000.0d, 0.0000000157451d },
            { 20000.0d, 0.0000000188472d },
            { 21000.0d, 0.0000000223347d },
            { 22000.0d, 0.0000000261978d },
            { 23000.0d, 0.000000030478d },
            { 24000.0d, 0.0000000351637d },
            { 25000.0d, 0.0000000402879d },
            { 26000.0d, 0.0000000458436d },
            { 27000.0d, 0.0000000518549d },
            { 28000.0d, 0.0000000583144d },
            { 29000.0d, 0.0000000652473d },
            { 30000.0d, 0.0000000726485d },
            { 31000.0d, 0.0000000805266d },
            { 32000.0d, 0.0000000888803d },
            { 33000.0d, 0.0000000977271d },
            { 34000.0d, 0.000000107064d },
            { 35000.0d, 0.000000116886d },
            { 36000.0d, 0.000000127196d },
            { 37000.0d, 0.000000138006d },
            { 38000.0d, 0.00000014931d },
            { 39000.0d, 0.0000001611d },
            { 40000.0d, 0.000000173379d },
            { 41000.0d, 0.000000186155d },
            { 42000.0d, 0.000000199424d },
            { 43000.0d, 0.000000213166d },
            { 44000.0d, 0.000000227385d },
            { 45000.0d, 0.000000242093d },
            { 46000.0d, 0.000000257283d },
            { 47000.0d, 0.000000272928d },
            { 48000.0d, 0.000000289036d },
            { 49000.0d, 0.000000305617d },
            { 50000.0d, 0.000000322664d },
            { 51000.0d, 0.000000340138d },
            { 52000.0d, 0.000000358051d },
            { 53000.0d, 0.000000376422d },
            { 54000.0d, 0.000000395238d },
            { 55000.0d, 0.000000414452d },
            { 56000.0d, 0.000000434082d },
            { 57000.0d, 0.000000454145d },
            { 58000.0d, 0.000000474625d },
            { 59000.0d, 0.00000049548d },
            { 60000.0d, 0.000000516728d },
            { 61000.0d, 0.000000538376d },
            { 62000.0d, 0.000000560414d },
            { 63000.0d, 0.000000582795d },
            { 64000.0d, 0.000000605541d },
            { 65000.0d, 0.000000628658d },
            { 66000.0d, 0.000000652139d },
            { 67000.0d, 0.000000675936d },
            { 68000.0d, 0.00000070007d },
            { 69000.0d, 0.000000724544d },
            { 70000.0d, 0.000000749347d },
            { 71000.0d, 0.000000774441d },
            { 72000.0d, 0.000000799843d },
            { 73000.0d, 0.000000825555d },
            { 74000.0d, 0.00000085156d },
            { 75000.0d, 0.000000877838d },
            { 76000.0d, 0.000000904403d },
            { 77000.0d, 0.000000931229d },
            { 78000.0d, 0.000000958321d },
            { 79000.0d, 0.000000985651d },
            { 80000.0d, 0.00000101324d },
            { 81000.0d, 0.00000104107d },
            { 82000.0d, 0.00000106913d },
            { 83000.0d, 0.00000109743d },
            { 84000.0d, 0.00000112596d },
            { 85000.0d, 0.00000115467d },
            { 86000.0d, 0.00000118358d },
            { 87000.0d, 0.0000012127d },
            { 88000.0d, 0.00000124203d },
            { 89000.0d, 0.00000127153d },
            { 90000.0d, 0.00000130121d },
            { 91000.0d, 0.00000133106d },
            { 92000.0d, 0.00000136107d },
            { 93000.0d, 0.00000139126d },
            { 94000.0d, 0.0000014216d },
            { 95000.0d, 0.00000145207d },
            { 96000.0d, 0.00000148268d },
            { 97000.0d, 0.00000151344d },
            { 98000.0d, 0.00000154433d },
            { 99000.0d, 0.00000157532d },
            { 100000.0d, 0.00000160644d },
            { 102000.0d, 0.00000166902d },
            { 104000.0d, 0.00000173197d },
            { 106000.0d, 0.00000179529d },
            { 108000.0d, 0.00000185893d },
            { 110000.0d, 0.00000192278d },
            { 112000.0d, 0.00000198697d },
            { 114000.0d, 0.00000205121d },
            { 116000.0d, 0.00000211569d },
            { 118000.0d, 0.00000218028d },
            { 120000.0d, 0.00000224489d },
            { 122000.0d, 0.00000230955d },
            { 124000.0d, 0.0000023743d },
            { 126000.0d, 0.00000243891d },
            { 128000.0d, 0.00000250347d },
            { 130000.0d, 0.00000256799d },
            { 132000.0d, 0.00000263242d },
            { 134000.0d, 0.00000269662d },
            { 136000.0d, 0.00000276063d },
            { 138000.0d, 0.00000282446d },
            { 140000.0d, 0.00000288813d },
            { 142000.0d, 0.00000295149d },
            { 144000.0d, 0.00000301454d },
            { 146000.0d, 0.00000307725d },
            { 148000.0d, 0.00000313967d },
            { 150000.0d, 0.00000320177d },
            { 152000.0d, 0.00000326353d },
            { 154000.0d, 0.00000332486d },
            { 156000.0d, 0.00000338575d },
            { 158000.0d, 0.00000344619d },
            { 160000.0d, 0.00000350616d },
            { 162000.0d, 0.00000356568d },
            { 164000.0d, 0.00000362473d },
            { 166000.0d, 0.00000368328d },
            { 168000.0d, 0.00000374133d },
            { 170000.0d, 0.00000379885d },
            { 172000.0d, 0.00000385583d },
            { 174000.0d, 0.00000391223d },
            { 176000.0d, 0.00000396806d },
            { 178000.0d, 0.0000040233d },
            { 180000.0d, 0.00000407793d },
            { 182000.0d, 0.00000413195d },
            { 184000.0d, 0.00000418533d },
            { 186000.0d, 0.0000042381d },
            { 188000.0d, 0.0000042902d },
            { 190000.0d, 0.00000434168d },
            { 192000.0d, 0.00000439248d },
            { 194000.0d, 0.0000044426d },
            { 196000.0d, 0.00000449207d },
            { 198000.0d, 0.00000454084d },
            { 200000.0d, 0.00000458892d },
            { 202000.0d, 0.0000046363d },
            { 204000.0d, 0.00000468296d },
            { 206000.0d, 0.00000472892d },
            { 208000.0d, 0.00000477416d },
            { 210000.0d, 0.00000481866d },
            { 212000.0d, 0.00000486243d },
            { 214000.0d, 0.00000490547d },
            { 216000.0d, 0.00000494775d },
            { 218000.0d, 0.0000049893d },
            { 220000.0d, 0.0000050301d },
            { 222000.0d, 0.00000507015d },
            { 224000.0d, 0.00000510944d },
            { 226000.0d, 0.00000514799d },
            { 228000.0d, 0.00000518578d },
            { 230000.0d, 0.00000522281d },
            { 232000.0d, 0.00000525908d },
            { 234000.0d, 0.00000529457d },
            { 236000.0d, 0.00000532929d },
            { 238000.0d, 0.00000536322d },
            { 240000.0d, 0.00000539634d },
            { 242000.0d, 0.00000542869d },
            { 244000.0d, 0.00000546026d },
            { 246000.0d, 0.00000549106d },
            { 248000.0d, 0.0000055211d },
            { 250000.0d, 0.00000555041d },
            { 252000.0d, 0.00000557893d },
            { 254000.0d, 0.00000560666d },
            { 256000.0d, 0.00000563361d },
            { 258000.0d, 0.00000565975d },
            { 260000.0d, 0.00000568507d },
            { 262000.0d, 0.00000570964d },
            { 264000.0d, 0.00000573348d },
            { 266000.0d, 0.00000575655d },
            { 268000.0d, 0.00000577885d },
            { 270000.0d, 0.00000580036d },
            { 272000.0d, 0.00000582109d },
            { 274000.0d, 0.00000584104d },
            { 276000.0d, 0.00000586021d },
            { 278000.0d, 0.00000587862d },
            { 280000.0d, 0.00000589632d },
            { 282000.0d, 0.00000591327d },
            { 284000.0d, 0.00000592947d },
            { 286000.0d, 0.00000594485d },
            { 288000.0d, 0.00000595947d },
            { 290000.0d, 0.00000597335d },
            { 292000.0d, 0.00000598655d },
            { 294000.0d, 0.00000599902d },
            { 296000.0d, 0.00000601075d },
            { 298000.0d, 0.00000602169d },
            { 300000.0d, 0.00000603189d },
            { 302000.0d, 0.00000604138d },
            { 304000.0d, 0.0000060502d },
            { 306000.0d, 0.00000605831d },
            { 308000.0d, 0.0000060657d },
            { 310000.0d, 0.00000607234d },
            { 312000.0d, 0.00000607824d },
            { 314000.0d, 0.00000608346d },
            { 316000.0d, 0.00000608797d },
            { 318000.0d, 0.0000060918d },
            { 320000.0d, 0.00000609494d },
            { 322000.0d, 0.00000609741d },
            { 324000.0d, 0.00000609921d },
            { 326000.0d, 0.00000610035d },
            { 328000.0d, 0.00000610078d },
            { 330000.0d, 0.00000610053d },
            { 332000.0d, 0.00000609961d },
            { 334000.0d, 0.00000609806d },
            { 336000.0d, 0.00000609584d },
            { 338000.0d, 0.000006093d },
            { 340000.0d, 0.00000608951d },
            { 342000.0d, 0.00000608543d },
            { 344000.0d, 0.00000608071d },
            { 346000.0d, 0.00000607537d },
            { 348000.0d, 0.00000606941d },
            { 350000.0d, 0.00000606284d },
            { 352000.0d, 0.00000605566d },
            { 354000.0d, 0.00000604787d },
            { 356000.0d, 0.00000603946d },
            { 358000.0d, 0.00000603047d },
            { 360000.0d, 0.00000602091d },
            { 362000.0d, 0.00000601075d },
            { 364000.0d, 0.00000600003d },
            { 366000.0d, 0.00000598874d },
            { 368000.0d, 0.0000059769d },
            { 370000.0d, 0.00000596449d },
            { 372000.0d, 0.00000595156d },
            { 374000.0d, 0.00000593809d },
            { 376000.0d, 0.00000592408d },
            { 378000.0d, 0.00000590956d },
            { 380000.0d, 0.00000589452d },
            { 382000.0d, 0.00000587899d },
            { 384000.0d, 0.00000586293d },
            { 386000.0d, 0.00000584639d },
            { 388000.0d, 0.00000582938d },
            { 390000.0d, 0.00000581188d },
            { 392000.0d, 0.00000579391d },
            { 394000.0d, 0.00000577546d },
            { 396000.0d, 0.00000575657d },
            { 398000.0d, 0.00000573722d },
            { 400000.0d, 0.00000571742d },
            { 402000.0d, 0.00000569719d },
            { 404000.0d, 0.00000567652d },
            { 406000.0d, 0.00000565545d },
            { 408000.0d, 0.00000563395d },
            { 410000.0d, 0.00000561204d },
            { 412000.0d, 0.00000558975d },
            { 414000.0d, 0.00000556705d },
            { 416000.0d, 0.00000554398d },
            { 418000.0d, 0.00000552054d },
            { 420000.0d, 0.00000549672d },
            { 422000.0d, 0.00000547255d },
            { 424000.0d, 0.00000544802d },
            { 426000.0d, 0.00000542313d },
            { 428000.0d, 0.00000539789d },
            { 430000.0d, 0.00000537227d },
            { 432000.0d, 0.00000534626d },
            { 434000.0d, 0.00000531987d },
            { 436000.0d, 0.00000529313d },
            { 438000.0d, 0.00000526604d },
            { 440000.0d, 0.00000523859d },
            { 442000.0d, 0.00000521081d },
            { 444000.0d, 0.0000051827d },
            { 446000.0d, 0.00000515427d },
            { 448000.0d, 0.00000512551d },
            { 450000.0d, 0.00000509646d },
            { 452000.0d, 0.00000506709d },
            { 454000.0d, 0.00000503743d },
            { 456000.0d, 0.00000500746d },
            { 458000.0d, 0.00000497722d },
            { 460000.0d, 0.0000049467d },
            { 462000.0d, 0.00000491591d },
            { 464000.0d, 0.00000488486d },
            { 466000.0d, 0.00000485357d },
            { 468000.0d, 0.00000482203d },
            { 470000.0d, 0.00000479026d },
            { 472000.0d, 0.00000475827d },
            { 474000.0d, 0.00000472606d },
            { 476000.0d, 0.00000469366d },
            { 478000.0d, 0.00000466104d },
            { 480000.0d, 0.00000462822d },
            { 482000.0d, 0.0000045952d },
            { 484000.0d, 0.00000456199d },
            { 486000.0d, 0.0000045286d },
            { 488000.0d, 0.00000449504d },
            { 490000.0d, 0.00000446133d },
            { 492000.0d, 0.00000442748d },
            { 494000.0d, 0.00000439349d },
            { 496000.0d, 0.00000435937d },
            { 498000.0d, 0.00000432512d },
            { 500000.0d, 0.00000429072d },
            { 502000.0d, 0.00000425622d },
            { 504000.0d, 0.00000422162d },
            { 506000.0d, 0.0000041869d },
            { 508000.0d, 0.00000415211d },
            { 510000.0d, 0.00000411724d },
            { 512000.0d, 0.00000408231d },
            { 514000.0d, 0.00000404733d },
            { 516000.0d, 0.00000401228d },
            { 518000.0d, 0.00000397719d },
            { 520000.0d, 0.00000394206d },
            { 522000.0d, 0.00000390691d },
            { 524000.0d, 0.00000387174d },
            { 526000.0d, 0.00000383655d },
            { 528000.0d, 0.00000380136d },
            { 530000.0d, 0.00000376618d },
            { 532000.0d, 0.000003731d },
            { 534000.0d, 0.00000369585d },
            { 536000.0d, 0.00000366073d },
            { 538000.0d, 0.00000362566d },
            { 540000.0d, 0.00000359062d },
            { 542000.0d, 0.00000355565d },
            { 544000.0d, 0.00000352075d },
            { 546000.0d, 0.00000348592d },
            { 548000.0d, 0.00000345118d },
            { 550000.0d, 0.00000341652d },
            { 552000.0d, 0.00000338198d },
            { 554000.0d, 0.00000334754d },
            { 556000.0d, 0.00000331322d },
            { 558000.0d, 0.00000327904d },
            { 560000.0d, 0.00000324499d },
            { 562000.0d, 0.00000321109d },
            { 564000.0d, 0.00000317734d },
            { 566000.0d, 0.00000314376d },
            { 568000.0d, 0.00000311035d },
            { 570000.0d, 0.00000307713d },
            { 572000.0d, 0.0000030441d },
            { 574000.0d, 0.00000301126d },
            { 576000.0d, 0.00000297864d },
            { 578000.0d, 0.00000294624d },
            { 580000.0d, 0.00000291406d },
            { 582000.0d, 0.00000288213d },
            { 584000.0d, 0.00000285043d },
            { 586000.0d, 0.00000281898d },
            { 588000.0d, 0.00000278767d },
            { 590000.0d, 0.00000275655d },
            { 592000.0d, 0.00000272559d },
            { 594000.0d, 0.0000026948d },
            { 596000.0d, 0.0000026642d },
            { 598000.0d, 0.0000026338d },
            { 600000.0d, 0.00000260356d },
            { 602000.0d, 0.00000257341d },
            { 604000.0d, 0.0000025433d },
            { 606000.0d, 0.00000251322d },
            { 608000.0d, 0.00000248317d },
            { 610000.0d, 0.00000245319d },
            { 612000.0d, 0.00000242325d },
            { 614000.0d, 0.00000239337d },
            { 616000.0d, 0.00000236354d },
            { 618000.0d, 0.00000233379d },
            { 620000.0d, 0.00000230412d },
            { 622000.0d, 0.00000227452d },
            { 624000.0d, 0.000002245d },
            { 626000.0d, 0.00000221556d },
            { 628000.0d, 0.00000218615d },
            { 630000.0d, 0.00000215681d },
            { 632000.0d, 0.00000212753d },
            { 634000.0d, 0.00000209832d },
            { 636000.0d, 0.00000206917d },
            { 638000.0d, 0.0000020401d },
            { 640000.0d, 0.00000201112d },
            { 642000.0d, 0.00000198221d },
            { 644000.0d, 0.0000019534d },
            { 646000.0d, 0.00000192468d },
            { 648000.0d, 0.00000189607d },
            { 650000.0d, 0.00000186755d },
            { 652000.0d, 0.00000183915d },
            { 654000.0d, 0.00000181086d },
            { 656000.0d, 0.0000017827d },
            { 658000.0d, 0.00000175465d },
            { 660000.0d, 0.00000172674d },
            { 662000.0d, 0.00000169897d },
            { 664000.0d, 0.00000167134d },
            { 666000.0d, 0.00000164385d },
            { 668000.0d, 0.00000161651d },
            { 670000.0d, 0.00000158933d },
            { 672000.0d, 0.00000156232d },
            { 674000.0d, 0.00000153546d },
            { 676000.0d, 0.00000150878d },
            { 678000.0d, 0.00000148227d },
            { 680000.0d, 0.00000145594d },
            { 682000.0d, 0.0000014298d },
            { 684000.0d, 0.00000140385d },
            { 686000.0d, 0.00000137809d },
            { 688000.0d, 0.00000135254d },
            { 690000.0d, 0.0000013272d },
            { 692000.0d, 0.00000130207d },
            { 694000.0d, 0.00000127716d },
            { 696000.0d, 0.00000125247d },
            { 698000.0d, 0.00000122801d },
            { 700000.0d, 0.00000120378d },
            { 702000.0d, 0.00000117979d },
            { 704000.0d, 0.00000115604d },
            { 706000.0d, 0.00000113253d },
            { 708000.0d, 0.00000110929d },
            { 710000.0d, 0.0000010863d },
            { 712000.0d, 0.00000106355d },
            { 714000.0d, 0.00000104098d },
            { 716000.0d, 0.00000101857d },
            { 718000.0d, 0.00000099633d },
            { 720000.0d, 0.000000974257d },
            { 722000.0d, 0.000000952332d },
            { 724000.0d, 0.000000930556d },
            { 726000.0d, 0.000000908933d },
            { 728000.0d, 0.000000887467d },
            { 730000.0d, 0.000000866159d },
            { 732000.0d, 0.000000845018d },
            { 734000.0d, 0.000000824044d },
            { 736000.0d, 0.000000803241d },
            { 738000.0d, 0.000000782614d },
            { 740000.0d, 0.000000762166d },
            { 742000.0d, 0.000000741901d },
            { 744000.0d, 0.000000721822d },
            { 746000.0d, 0.000000701935d },
            { 748000.0d, 0.00000068224d },
            { 750000.0d, 0.000000662744d },
            { 752000.0d, 0.00000064345d },
            { 754000.0d, 0.000000624361d },
            { 756000.0d, 0.000000605482d },
            { 758000.0d, 0.000000586818d },
            { 760000.0d, 0.000000568369d },
            { 762000.0d, 0.000000550143d },
            { 764000.0d, 0.00000053214d },
            { 766000.0d, 0.000000514367d },
            { 768000.0d, 0.000000496828d },
            { 770000.0d, 0.000000479524d },
            { 772000.0d, 0.000000462461d },
            { 774000.0d, 0.000000445642d },
            { 776000.0d, 0.000000429073d },
            { 778000.0d, 0.000000412754d },
            { 780000.0d, 0.000000396693d },
            { 782000.0d, 0.000000380892d },
            { 784000.0d, 0.000000365355d },
            { 786000.0d, 0.000000350085d },
            { 788000.0d, 0.000000335088d },
            { 790000.0d, 0.000000320367d },
            { 792000.0d, 0.000000305925d },
            { 794000.0d, 0.000000291767d },
            { 796000.0d, 0.000000277897d },
            { 798000.0d, 0.00000026432d },
            { 800000.0d, 0.000000251037d },
            { 802000.0d, 0.000000238055d },
            { 804000.0d, 0.000000225376d },
            { 806000.0d, 0.000000213006d },
            { 808000.0d, 0.000000200947d },
            { 810000.0d, 0.000000189204d },
            { 812000.0d, 0.00000017778d },
            { 814000.0d, 0.000000166681d },
            { 816000.0d, 0.000000155909d },
            { 818000.0d, 0.000000145469d },
            { 820000.0d, 0.000000135366d },
            { 822000.0d, 0.000000125602d },
            { 824000.0d, 0.000000116182d },
            { 826000.0d, 0.000000107111d },
            { 828000.0d, 0.0000000983914d },
            { 830000.0d, 0.0000000900282d },
            { 832000.0d, 0.0000000820252d },
            { 834000.0d, 0.0000000743866d },
            { 836000.0d, 0.0000000671164d },
            { 838000.0d, 0.0000000602185d },
            { 840000.0d, 0.0000000536972d },
            { 842000.0d, 0.0000000475565d },
            { 844000.0d, 0.0000000418002d },
            { 846000.0d, 0.0000000364326d },
            { 848000.0d, 0.0000000314574d },
            { 850000.0d, 0.0000000268594d },
            { 852000.0d, 0.0000000226282d },
            { 854000.0d, 0.0000000187677d },
            { 856000.0d, 0.0000000152815d },
            { 858000.0d, 0.0000000121734d },
            { 860000.0d, 0.00000000944693d },
            { 862000.0d, 0.00000000710582d },
            { 864000.0d, 0.00000000515365d },
            { 866000.0d, 0.00000000359386d },
            { 868000.0d, 0.00000000242959d },
            { 870000.0d, 0.00000000154533d },
            { 872000.0d, 0.000000000858611d },
            { 874000.0d, 0.000000000371128d },
            { 876000.0d, 0.0000000000844967d },
            { 878000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    