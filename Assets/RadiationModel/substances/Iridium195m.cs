using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium195m";
        public override double halfLife { get; } = 13212.0d;
        public override double atomicWeight { get; } = 194.96608d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum195()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(7.5e-12d, new GammaParticle(19800.0, 0.06262)), new(0.0023d, new GammaParticle(27800.0, 0.0446)), new(0.019d, new GammaParticle(30850.0, 0.04019)), new(0.0147d, new GammaParticle(60400.0, 0.02053)), new(0.107d, new GammaParticle(98850.0, 0.01254)), new(0.001d, new GammaParticle(100652.0, 0.01232)), new(0.001d, new GammaParticle(115000.0, 0.01078)), new(0.0039000000000000003d, new GammaParticle(119120.0, 0.01041)), new(0.0039000000000000003d, new GammaParticle(119120.0, 0.01041)), new(0.00037999999999999997d, new GammaParticle(129500.0, 0.00957)), new(0.017d, new GammaParticle(129700.0, 0.00956)), new(0.0008d, new GammaParticle(130300.0, 0.00952)), new(0.0078000000000000005d, new GammaParticle(140500.0, 0.00882)), new(0.001d, new GammaParticle(147600.0, 0.0084)), new(0.0018d, new GammaParticle(150110.0, 0.00826)), new(0.051d, new GammaParticle(172780.0, 0.00718)), new(0.0008799999999999999d, new GammaParticle(178460.0, 0.00695)), new(0.001d, new GammaParticle(197440.0, 0.00628)), new(0.0059d, new GammaParticle(199580.0, 0.00621)), new(0.0078000000000000005d, new GammaParticle(201650.0, 0.00615)), new(0.02d, new GammaParticle(211300.0, 0.00587)), new(0.0026d, new GammaParticle(211300.0, 0.00587)), new(0.0088d, new GammaParticle(216000.0, 0.00574)), new(9.8e-05d, new GammaParticle(223700.0, 0.00554)), new(0.0026d, new GammaParticle(235400.0, 0.00527)), new(0.017d, new GammaParticle(239210.0, 0.00518)), new(0.00127d, new GammaParticle(239210.0, 0.00518)), new(0.0078000000000000005d, new GammaParticle(243870.0, 0.00508)), new(0.019d, new GammaParticle(251610.0, 0.00493)), new(0.0088d, new GammaParticle(255790.0, 0.00485)), new(0.0078000000000000005d, new GammaParticle(259330.0, 0.00478)), new(0.0005899999999999999d, new GammaParticle(264500.0, 0.00469)), new(0.0059d, new GammaParticle(267100.0, 0.00464)), new(0.00039d, new GammaParticle(270700.0, 0.00458)), new(0.00039d, new GammaParticle(277000.0, 0.00448)), new(0.0005899999999999999d, new GammaParticle(283000.0, 0.00438)), new(0.01d, new GammaParticle(287800.0, 0.00431)), new(0.02d, new GammaParticle(290300.0, 0.00427)), new(0.0139d, new GammaParticle(306480.0, 0.00405)), new(0.0086d, new GammaParticle(306480.0, 0.00405)), new(0.098d, new GammaParticle(319900.0, 0.00388)), new(0.0078000000000000005d, new GammaParticle(325180.0, 0.00381)), new(0.0008d, new GammaParticle(333200.0, 0.00372)), new(0.0104d, new GammaParticle(350900.0, 0.00353)), new(0.019d, new GammaParticle(356380.0, 0.00348)), new(0.047d, new GammaParticle(359310.0, 0.00345)), new(0.09699999999999999d, new GammaParticle(364940.0, 0.0034)), new(0.011000000000000001d, new GammaParticle(373390.0, 0.00332)), new(0.01d, new GammaParticle(378240.0, 0.00328)), new(0.0024d, new GammaParticle(383300.0, 0.00323)), new(0.0024d, new GammaParticle(383300.0, 0.00323)), new(0.0017000000000000001d, new GammaParticle(385200.0, 0.00322)), new(0.0032d, new GammaParticle(387100.0, 0.0032)), new(0.0059d, new GammaParticle(389850.0, 0.00318)), new(0.0005d, new GammaParticle(395700.0, 0.00313)), new(0.0029d, new GammaParticle(401300.0, 0.00309)), new(0.015d, new GammaParticle(409040.0, 0.00303)), new(0.0026d, new GammaParticle(413600.0, 0.003)), new(0.0039000000000000003d, new GammaParticle(419690.0, 0.00295)), new(0.0014000000000000002d, new GammaParticle(422400.0, 0.00294)), new(0.0068000000000000005d, new GammaParticle(425410.0, 0.00291)), new(0.0068000000000000005d, new GammaParticle(427800.0, 0.0029)), new(0.098d, new GammaParticle(432860.0, 0.00286)), new(0.0022d, new GammaParticle(440400.0, 0.00282)), new(0.0048d, new GammaParticle(445550.0, 0.00278)), new(0.0079d, new GammaParticle(455940.0, 0.00272)), new(0.0005899999999999999d, new GammaParticle(463600.0, 0.00267)), new(0.0016d, new GammaParticle(475380.0, 0.00261)), new(0.027000000000000003d, new GammaParticle(481170.0, 0.00258)), new(0.0052d, new GammaParticle(495800.0, 0.0025)), new(0.0012d, new GammaParticle(498600.0, 0.00249)), new(0.0066d, new GammaParticle(506160.0, 0.00245)), new(0.00029d, new GammaParticle(513600.0, 0.00241)), new(0.00068d, new GammaParticle(524500.0, 0.00236)), new(0.00029d, new GammaParticle(526700.0, 0.00235)), new(0.00068d, new GammaParticle(530100.0, 0.00234)), new(0.0034999999999999996d, new GammaParticle(534100.0, 0.00232)), new(0.0016d, new GammaParticle(537400.0, 0.00231)), new(0.0002d, new GammaParticle(540400.0, 0.00229)), new(0.0002d, new GammaParticle(544500.0, 0.00228)), new(0.00029d, new GammaParticle(548100.0, 0.00226)), new(0.0023d, new GammaParticle(565480.0, 0.00219)), new(0.016d, new GammaParticle(575350.0, 0.00215)), new(0.0022d, new GammaParticle(596480.0, 0.00208)), new(0.00049d, new GammaParticle(611100.0, 0.00203)), new(0.0002d, new GammaParticle(613600.0, 0.00202)), new(0.002d, new GammaParticle(616500.0, 0.00201)), new(0.00049d, new GammaParticle(619200.0, 0.002)), new(0.098d, new GammaParticle(684880.0, 0.00181)), new(0.00049d, new GammaParticle(691600.0, 0.00179)), new(0.0005899999999999999d, new GammaParticle(715500.0, 0.00173)), new(0.002d, new GammaParticle(723700.0, 0.00171)), new(0.0021d, new GammaParticle(750800.0, 0.00165)), new(0.0008799999999999999d, new GammaParticle(784100.0, 0.00158)), new(0.0108d, new GammaParticle(800900.0, 0.00155)), new(0.535728487877396d, new GammaParticle(11070.0, 0.112)), new(0.2209925287207149d, new GammaParticle(65122.0, 0.01904)), new(0.3777650063601964d, new GammaParticle(66832.0, 0.01855)), new(0.12710793707394152d, new GammaParticle(75821.0, 0.01635)), new(0.1634608070770888d, new GammaParticle(76725.0, 0.01616)), new(0.03635287000314727d, new GammaParticle(77832.0, 0.01593)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium195()), new(1e-05d, new GammaParticle(100000.0, 0.0124)), new(0.011313526400000001d, new GammaParticle(10728.0, 0.11557)), new(0.0006654816047570965d, new GammaParticle(63287.0, 0.01959)), new(0.0011420655650542242d, new GammaParticle(64896.0, 0.01911)), new(0.0003832056353769909d, new GammaParticle(73637.0, 0.01684)), new(0.0004916528301886793d, new GammaParticle(74510.0, 0.01664)), new(0.00010844719481168841d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0035234d },
            { 900.0d, 0.00363004d },
            { 1800.0d, 0.00369405d },
            { 2700.0d, 0.00371545d },
            { 3600.0d, 0.00371791d },
            { 4500.0d, 0.00371889d },
            { 5400.0d, 0.00371807d },
            { 6300.0d, 0.00371599d },
            { 7200.0d, 0.00371335d },
            { 8100.0d, 0.00371002d },
            { 9000.0d, 0.00370619d },
            { 9900.0d, 0.00370207d },
            { 10000.0d, 0.00370158d },
            { 11000.0d, 0.00369661d },
            { 12000.0d, 0.0036913d },
            { 13000.0d, 0.00368574d },
            { 14000.0d, 0.00367996d },
            { 15000.0d, 0.00367397d },
            { 16000.0d, 0.00366783d },
            { 17000.0d, 0.00366153d },
            { 18000.0d, 0.00365511d },
            { 19000.0d, 0.00364857d },
            { 20000.0d, 0.00364192d },
            { 21000.0d, 0.00363517d },
            { 22000.0d, 0.00362833d },
            { 23000.0d, 0.0036214d },
            { 24000.0d, 0.0036144d },
            { 25000.0d, 0.00360732d },
            { 26000.0d, 0.00360017d },
            { 27000.0d, 0.00359295d },
            { 28000.0d, 0.00358566d },
            { 29000.0d, 0.00357832d },
            { 30000.0d, 0.00357091d },
            { 31000.0d, 0.00356344d },
            { 32000.0d, 0.0035559d },
            { 33000.0d, 0.00354833d },
            { 34000.0d, 0.00354068d },
            { 35000.0d, 0.003533d },
            { 36000.0d, 0.00352526d },
            { 37000.0d, 0.00351745d },
            { 38000.0d, 0.00350961d },
            { 39000.0d, 0.00350171d },
            { 40000.0d, 0.00349378d },
            { 41000.0d, 0.00348579d },
            { 42000.0d, 0.00347776d },
            { 43000.0d, 0.00346967d },
            { 44000.0d, 0.00346155d },
            { 45000.0d, 0.00345337d },
            { 46000.0d, 0.00344516d },
            { 47000.0d, 0.00343691d },
            { 48000.0d, 0.00342861d },
            { 49000.0d, 0.00342027d },
            { 50000.0d, 0.00341189d },
            { 51000.0d, 0.00340346d },
            { 52000.0d, 0.003395d },
            { 53000.0d, 0.0033865d },
            { 54000.0d, 0.00337796d },
            { 55000.0d, 0.00336938d },
            { 56000.0d, 0.00336077d },
            { 57000.0d, 0.00335212d },
            { 58000.0d, 0.00334343d },
            { 59000.0d, 0.0033347d },
            { 60000.0d, 0.00332594d },
            { 61000.0d, 0.00331715d },
            { 62000.0d, 0.00330831d },
            { 63000.0d, 0.00329945d },
            { 64000.0d, 0.00329055d },
            { 65000.0d, 0.00328162d },
            { 66000.0d, 0.00327265d },
            { 67000.0d, 0.00326366d },
            { 68000.0d, 0.00325464d },
            { 69000.0d, 0.00324558d },
            { 70000.0d, 0.00323647d },
            { 71000.0d, 0.00322735d },
            { 72000.0d, 0.00321821d },
            { 73000.0d, 0.00320903d },
            { 74000.0d, 0.00319981d },
            { 75000.0d, 0.00319057d },
            { 76000.0d, 0.0031813d },
            { 77000.0d, 0.003172d },
            { 78000.0d, 0.00316268d },
            { 79000.0d, 0.00315333d },
            { 80000.0d, 0.00314395d },
            { 81000.0d, 0.00313454d },
            { 82000.0d, 0.00312511d },
            { 83000.0d, 0.00311565d },
            { 84000.0d, 0.00310616d },
            { 85000.0d, 0.00309666d },
            { 86000.0d, 0.00308712d },
            { 87000.0d, 0.00307756d },
            { 88000.0d, 0.00306798d },
            { 89000.0d, 0.00305837d },
            { 90000.0d, 0.00304874d },
            { 91000.0d, 0.00303909d },
            { 92000.0d, 0.00302941d },
            { 93000.0d, 0.00301972d },
            { 94000.0d, 0.00301d },
            { 95000.0d, 0.00300026d },
            { 96000.0d, 0.0029905d },
            { 97000.0d, 0.00298071d },
            { 98000.0d, 0.00297091d },
            { 99000.0d, 0.00296109d },
            { 100000.0d, 0.00295124d },
            { 103000.0d, 0.00292159d },
            { 106000.0d, 0.00289179d },
            { 109000.0d, 0.00286183d },
            { 112000.0d, 0.00283172d },
            { 115000.0d, 0.00280147d },
            { 118000.0d, 0.0027711d },
            { 121000.0d, 0.00274062d },
            { 124000.0d, 0.00271002d },
            { 127000.0d, 0.00267934d },
            { 130000.0d, 0.00264856d },
            { 133000.0d, 0.00261771d },
            { 136000.0d, 0.00258678d },
            { 139000.0d, 0.00255581d },
            { 142000.0d, 0.00252478d },
            { 145000.0d, 0.00249372d },
            { 148000.0d, 0.00246264d },
            { 151000.0d, 0.00243153d },
            { 154000.0d, 0.00240042d },
            { 157000.0d, 0.00236931d },
            { 160000.0d, 0.00233823d },
            { 163000.0d, 0.00230716d },
            { 166000.0d, 0.00227613d },
            { 169000.0d, 0.00224515d },
            { 172000.0d, 0.00221423d },
            { 175000.0d, 0.00218338d },
            { 178000.0d, 0.0021526d },
            { 181000.0d, 0.00212192d },
            { 184000.0d, 0.00209134d },
            { 187000.0d, 0.00206088d },
            { 190000.0d, 0.00203054d },
            { 193000.0d, 0.00200034d },
            { 196000.0d, 0.00197028d },
            { 199000.0d, 0.00194039d },
            { 202000.0d, 0.00191067d },
            { 205000.0d, 0.00188113d },
            { 208000.0d, 0.00185179d },
            { 211000.0d, 0.00182265d },
            { 214000.0d, 0.00179374d },
            { 217000.0d, 0.00176505d },
            { 220000.0d, 0.00173662d },
            { 223000.0d, 0.00170843d },
            { 226000.0d, 0.00168052d },
            { 229000.0d, 0.00165289d },
            { 232000.0d, 0.00162555d },
            { 235000.0d, 0.00159853d },
            { 238000.0d, 0.00157182d },
            { 241000.0d, 0.00154544d },
            { 244000.0d, 0.00151941d },
            { 247000.0d, 0.00149374d },
            { 250000.0d, 0.00146844d },
            { 253000.0d, 0.00144353d },
            { 256000.0d, 0.00141901d },
            { 259000.0d, 0.0013949d },
            { 262000.0d, 0.00137123d },
            { 265000.0d, 0.00134799d },
            { 268000.0d, 0.0013252d },
            { 271000.0d, 0.00130287d },
            { 274000.0d, 0.00128092d },
            { 277000.0d, 0.00125924d },
            { 280000.0d, 0.00123783d },
            { 283000.0d, 0.00121672d },
            { 286000.0d, 0.00119591d },
            { 289000.0d, 0.00117541d },
            { 292000.0d, 0.00115523d },
            { 295000.0d, 0.00113539d },
            { 298000.0d, 0.00111588d },
            { 301000.0d, 0.00109673d },
            { 304000.0d, 0.00107793d },
            { 307000.0d, 0.00105951d },
            { 310000.0d, 0.00104145d },
            { 313000.0d, 0.00102371d },
            { 316000.0d, 0.00100632d },
            { 319000.0d, 0.000989275d },
            { 322000.0d, 0.000972593d },
            { 325000.0d, 0.000956286d },
            { 328000.0d, 0.000940355d },
            { 331000.0d, 0.000924816d },
            { 334000.0d, 0.000909677d },
            { 337000.0d, 0.000894948d },
            { 340000.0d, 0.00088064d },
            { 343000.0d, 0.000866759d },
            { 346000.0d, 0.00085332d },
            { 349000.0d, 0.00084033d },
            { 352000.0d, 0.000827802d },
            { 355000.0d, 0.000815741d },
            { 358000.0d, 0.000804163d },
            { 361000.0d, 0.000793074d },
            { 364000.0d, 0.000782486d },
            { 367000.0d, 0.000772409d },
            { 370000.0d, 0.000762854d },
            { 373000.0d, 0.00075383d },
            { 376000.0d, 0.000745348d },
            { 379000.0d, 0.000737419d },
            { 382000.0d, 0.000730051d },
            { 385000.0d, 0.000723258d },
            { 388000.0d, 0.000717047d },
            { 391000.0d, 0.000711119d },
            { 394000.0d, 0.000705168d },
            { 397000.0d, 0.000699197d },
            { 400000.0d, 0.000693205d },
            { 403000.0d, 0.000687194d },
            { 406000.0d, 0.000681165d },
            { 409000.0d, 0.000675119d },
            { 412000.0d, 0.000669056d },
            { 415000.0d, 0.000662978d },
            { 418000.0d, 0.000656885d },
            { 421000.0d, 0.000650778d },
            { 424000.0d, 0.000644659d },
            { 427000.0d, 0.000638529d },
            { 430000.0d, 0.000632387d },
            { 433000.0d, 0.000626236d },
            { 436000.0d, 0.000620077d },
            { 439000.0d, 0.00061391d },
            { 442000.0d, 0.000607737d },
            { 445000.0d, 0.000601559d },
            { 448000.0d, 0.000595376d },
            { 451000.0d, 0.000589189d },
            { 454000.0d, 0.000583001d },
            { 457000.0d, 0.000576812d },
            { 460000.0d, 0.000570623d },
            { 463000.0d, 0.000564435d },
            { 466000.0d, 0.000558249d },
            { 469000.0d, 0.000552068d },
            { 472000.0d, 0.000545891d },
            { 475000.0d, 0.000539719d },
            { 478000.0d, 0.000533556d },
            { 481000.0d, 0.0005274d },
            { 484000.0d, 0.000521254d },
            { 487000.0d, 0.00051512d },
            { 490000.0d, 0.000508997d },
            { 493000.0d, 0.000502889d },
            { 496000.0d, 0.000496794d },
            { 499000.0d, 0.000490716d },
            { 502000.0d, 0.000484655d },
            { 505000.0d, 0.000478613d },
            { 508000.0d, 0.000472592d },
            { 511000.0d, 0.000466583d },
            { 514000.0d, 0.000460587d },
            { 517000.0d, 0.000454605d },
            { 520000.0d, 0.000448639d },
            { 523000.0d, 0.000442689d },
            { 526000.0d, 0.000436755d },
            { 529000.0d, 0.00043084d },
            { 532000.0d, 0.000424943d },
            { 535000.0d, 0.000419067d },
            { 538000.0d, 0.000413213d },
            { 541000.0d, 0.00040738d },
            { 544000.0d, 0.000401571d },
            { 547000.0d, 0.000395788d },
            { 550000.0d, 0.00039003d },
            { 553000.0d, 0.000384298d },
            { 556000.0d, 0.000378595d },
            { 559000.0d, 0.000372921d },
            { 562000.0d, 0.000367278d },
            { 565000.0d, 0.000361666d },
            { 568000.0d, 0.000356087d },
            { 571000.0d, 0.000350542d },
            { 574000.0d, 0.000345032d },
            { 577000.0d, 0.000339559d },
            { 580000.0d, 0.000334123d },
            { 583000.0d, 0.000328726d },
            { 586000.0d, 0.000323369d },
            { 589000.0d, 0.000318054d },
            { 592000.0d, 0.000312782d },
            { 595000.0d, 0.000307552d },
            { 598000.0d, 0.000302368d },
            { 601000.0d, 0.000297231d },
            { 604000.0d, 0.000292142d },
            { 607000.0d, 0.000287103d },
            { 610000.0d, 0.000282113d },
            { 613000.0d, 0.000277176d },
            { 616000.0d, 0.000272291d },
            { 619000.0d, 0.000267461d },
            { 622000.0d, 0.000262687d },
            { 625000.0d, 0.000257971d },
            { 628000.0d, 0.000253313d },
            { 631000.0d, 0.000248717d },
            { 634000.0d, 0.000244181d },
            { 637000.0d, 0.000239709d },
            { 640000.0d, 0.000235299d },
            { 643000.0d, 0.000230926d },
            { 646000.0d, 0.000226583d },
            { 649000.0d, 0.000222271d },
            { 652000.0d, 0.000217991d },
            { 655000.0d, 0.000213743d },
            { 658000.0d, 0.000209529d },
            { 661000.0d, 0.000205346d },
            { 664000.0d, 0.000201194d },
            { 667000.0d, 0.000197077d },
            { 670000.0d, 0.000192995d },
            { 673000.0d, 0.000188948d },
            { 676000.0d, 0.000184939d },
            { 679000.0d, 0.000180967d },
            { 682000.0d, 0.000177034d },
            { 685000.0d, 0.000173143d },
            { 688000.0d, 0.000169293d },
            { 691000.0d, 0.000165486d },
            { 694000.0d, 0.000161723d },
            { 697000.0d, 0.000158003d },
            { 700000.0d, 0.000154321d },
            { 703000.0d, 0.000150678d },
            { 706000.0d, 0.000147075d },
            { 709000.0d, 0.000143515d },
            { 712000.0d, 0.000139998d },
            { 715000.0d, 0.000136525d },
            { 718000.0d, 0.000133097d },
            { 721000.0d, 0.000129716d },
            { 724000.0d, 0.000126382d },
            { 727000.0d, 0.000123097d },
            { 730000.0d, 0.000119862d },
            { 733000.0d, 0.000116679d },
            { 736000.0d, 0.000113549d },
            { 739000.0d, 0.000110472d },
            { 742000.0d, 0.000107451d },
            { 745000.0d, 0.000104486d },
            { 748000.0d, 0.000101579d },
            { 751000.0d, 0.0000987197d },
            { 754000.0d, 0.0000959064d },
            { 757000.0d, 0.0000931396d },
            { 760000.0d, 0.0000904201d },
            { 763000.0d, 0.0000877485d },
            { 766000.0d, 0.0000851256d },
            { 769000.0d, 0.0000825522d },
            { 772000.0d, 0.000080024d },
            { 775000.0d, 0.0000775257d },
            { 778000.0d, 0.0000750568d },
            { 781000.0d, 0.0000726177d },
            { 784000.0d, 0.000070209d },
            { 787000.0d, 0.0000678312d },
            { 790000.0d, 0.0000654847d },
            { 793000.0d, 0.0000631702d },
            { 796000.0d, 0.000060888d },
            { 799000.0d, 0.0000586388d },
            { 802000.0d, 0.0000564231d },
            { 805000.0d, 0.0000542414d },
            { 808000.0d, 0.0000520943d },
            { 811000.0d, 0.0000499821d },
            { 814000.0d, 0.0000479055d },
            { 817000.0d, 0.0000458651d },
            { 820000.0d, 0.0000438614d },
            { 823000.0d, 0.0000418949d },
            { 826000.0d, 0.000039966d },
            { 829000.0d, 0.0000380754d },
            { 832000.0d, 0.0000362237d },
            { 835000.0d, 0.0000344113d },
            { 838000.0d, 0.0000326387d },
            { 841000.0d, 0.0000309066d },
            { 844000.0d, 0.0000292154d },
            { 847000.0d, 0.0000275658d },
            { 850000.0d, 0.0000259582d },
            { 853000.0d, 0.0000243932d },
            { 856000.0d, 0.0000228714d },
            { 859000.0d, 0.0000213932d },
            { 862000.0d, 0.0000199593d },
            { 865000.0d, 0.0000185702d },
            { 868000.0d, 0.0000172265d },
            { 871000.0d, 0.0000159287d },
            { 874000.0d, 0.0000146773d },
            { 877000.0d, 0.0000134729d },
            { 880000.0d, 0.0000123162d },
            { 883000.0d, 0.0000112076d },
            { 886000.0d, 0.0000101475d },
            { 889000.0d, 0.00000913684d },
            { 892000.0d, 0.00000817592d },
            { 895000.0d, 0.00000726536d },
            { 898000.0d, 0.00000640571d },
            { 901000.0d, 0.00000559756d },
            { 904000.0d, 0.00000484143d },
            { 907000.0d, 0.00000413791d },
            { 910000.0d, 0.00000348754d },
            { 913000.0d, 0.0000028909d },
            { 916000.0d, 0.00000234853d },
            { 919000.0d, 0.00000186099d },
            { 922000.0d, 0.00000142885d },
            { 925000.0d, 0.00000105263d },
            { 928000.0d, 0.000000732908d },
            { 931000.0d, 0.000000470213d },
            { 934000.0d, 0.00000026508d },
            { 937000.0d, 0.000000118026d },
            { 940000.0d, 0.0000000295356d },
            { 943000.0d, 0d },

        }; 
    }
}
    