using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium173";
        public override double halfLife { get; } = 84960.0d;
        public override double atomicWeight { get; } = 172.94051d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(2.6477e-07d, new GammaParticle(4670.0, 0.26549)), new(0.0002573d, new GammaParticle(9594.0, 0.12923)), new(0.00052539d, new GammaParticle(77920.0, 0.01591)), new(0.0006225d, new GammaParticle(117180.0, 0.01058)), new(1.992e-05d, new GammaParticle(117180.0, 0.01058)), new(0.83d, new GammaParticle(123675.0, 0.01003)), new(0.047393d, new GammaParticle(134965.0, 0.00919)), new(0.12699d, new GammaParticle(139635.0, 0.00888)), new(0.06457399999999999d, new GammaParticle(162010.0, 0.00765)), new(0.0016932d, new GammaParticle(171604.0, 0.00723)), new(2.49e-05d, new GammaParticle(229610.0, 0.0054)), new(5.9760000000000004e-05d, new GammaParticle(239820.0, 0.00517)), new(0.00027888d, new GammaParticle(288790.0, 0.00429)), new(0.33864d, new GammaParticle(296974.0, 0.00417)), new(0.064242d, new GammaParticle(306568.0, 0.00404)), new(0.107485d, new GammaParticle(311239.0, 0.00398)), new(0.0046562999999999995d, new GammaParticle(356998.0, 0.00347)), new(8.3e-06d, new GammaParticle(377710.0, 0.00328)), new(0.0006307999999999999d, new GammaParticle(423060.0, 0.00293)), new(9.877e-05d, new GammaParticle(426940.0, 0.0029)), new(0.00012118d, new GammaParticle(428420.0, 0.00289)), new(8.881e-05d, new GammaParticle(429710.0, 0.00289)), new(4.316000000000001e-05d, new GammaParticle(444820.0, 0.00279)), new(8.881e-05d, new GammaParticle(451300.0, 0.00275)), new(3.32e-05d, new GammaParticle(458230.0, 0.00271)), new(1.245e-05d, new GammaParticle(492400.0, 0.00252)), new(0.0036935d, new GammaParticle(540238.0, 0.00229)), new(0.00030377999999999997d, new GammaParticle(546895.0, 0.00227)), new(0.0043741000000000006d, new GammaParticle(549832.0, 0.00225)), new(0.00012284d, new GammaParticle(556489.0, 0.00223)), new(8.3e-05d, new GammaParticle(568487.0, 0.00218)), new(0.00023489d, new GammaParticle(578081.0, 0.00214)), new(6.557e-05d, new GammaParticle(593200.0, 0.00209)), new(1.66e-05d, new GammaParticle(596000.0, 0.00208)), new(0.00024070000000000002d, new GammaParticle(618150.0, 0.00201)), new(0.00029963d, new GammaParticle(625917.0, 0.00198)), new(0.0001245d, new GammaParticle(694460.0, 0.00179)), new(0.0001245d, new GammaParticle(694460.0, 0.00179)), new(0.0029298999999999996d, new GammaParticle(718499.0, 0.00173)), new(5.0629999999999995e-05d, new GammaParticle(734710.0, 0.00169)), new(0.0002324d, new GammaParticle(740090.0, 0.00168)), new(0.0006723d, new GammaParticle(760881.0, 0.00163)), new(0.00015023d, new GammaParticle(765551.0, 0.00162)), new(4.15e-05d, new GammaParticle(781950.0, 0.00159)), new(1.245e-05d, new GammaParticle(807170.0, 0.00154)), new(0.00016517d, new GammaParticle(811610.0, 0.00153)), new(3.901e-05d, new GammaParticle(821200.0, 0.00151)), new(3.32e-05d, new GammaParticle(828390.0, 0.0015)), new(6.391e-05d, new GammaParticle(834100.0, 0.00149)), new(6.391e-05d, new GammaParticle(834100.0, 0.00149)), new(1.245e-05d, new GammaParticle(845400.0, 0.00147)), new(0.0032121d, new GammaParticle(853463.0, 0.00145)), new(1.66e-05d, new GammaParticle(857400.0, 0.00145)), new(8.3e-06d, new GammaParticle(866350.0, 0.00143)), new(0.0022742d, new GammaParticle(875054.0, 0.00142)), new(0.0038512000000000004d, new GammaParticle(879724.0, 0.00141)), new(3.569e-05d, new GammaParticle(889520.0, 0.00139)), new(0.0001079d, new GammaParticle(899123.0, 0.00138)), new(0.009877d, new GammaParticle(899123.0, 0.00138)), new(1.8259999999999998e-05d, new GammaParticle(905810.0, 0.00137)), new(5.0629999999999995e-05d, new GammaParticle(929360.0, 0.00133)), new(1.245e-05d, new GammaParticle(933940.0, 0.00133)), new(5.478e-05d, new GammaParticle(969050.0, 0.00128)), new(9.711e-05d, new GammaParticle(977050.0, 0.00127)), new(3.984e-05d, new GammaParticle(983210.0, 0.00126)), new(8.3e-06d, new GammaParticle(990000.0, 0.00125)), new(8.3e-06d, new GammaParticle(991800.0, 0.00125)), new(0.00011371d, new GammaParticle(1001310.0, 0.00124)), new(0.00020584000000000002d, new GammaParticle(1005980.0, 0.00123)), new(0.0042081d, new GammaParticle(1034087.0, 0.0012)), new(0.0032286999999999997d, new GammaParticle(1038757.0, 0.00119)), new(5.0629999999999995e-05d, new GammaParticle(1064320.0, 0.00116)), new(0.0007885d, new GammaParticle(1070740.0, 0.00116)), new(3.32e-06d, new GammaParticle(1085800.0, 0.00114)), new(1.245e-05d, new GammaParticle(1095950.0, 0.00113)), new(4.98e-06d, new GammaParticle(1100000.0, 0.00113)), new(0.00024983000000000004d, new GammaParticle(1118170.0, 0.00111)), new(1.66e-06d, new GammaParticle(1145430.0, 0.00108)), new(0.0029797d, new GammaParticle(1205700.0, 0.00103)), new(0.0008881d, new GammaParticle(1210370.0, 0.00102)), new(7.387e-06d, new GammaParticle(1230920.0, 0.00101)), new(1.66e-06d, new GammaParticle(1235590.0, 0.001)), new(1.66e-06d, new GammaParticle(1274600.0, 0.00097)), new(1.66e-06d, new GammaParticle(1280400.0, 0.00097)), new(7.4700000000000005e-06d, new GammaParticle(1286600.0, 0.00096)), new(5.81e-06d, new GammaParticle(1316000.0, 0.00094)), new(1.66e-06d, new GammaParticle(1332870.0, 0.00093)), new(8.3e-07d, new GammaParticle(1363900.0, 0.00091)), new(2.49e-06d, new GammaParticle(1428600.0, 0.00087)), new(4.15e-06d, new GammaParticle(1450000.0, 0.00086)), new(3.32e-06d, new GammaParticle(1488900.0, 0.00083)), new(1.66e-06d, new GammaParticle(1512500.0, 0.00082)), new(6.64e-06d, new GammaParticle(1778400.0, 0.0007)), new(2.49e-06d, new GammaParticle(2043000.0, 0.00061)), new(1.66e-06d, new GammaParticle(2127700.0, 0.00058)), new(1.66e-06d, new GammaParticle(2613100.0, 0.00047)), new(0.00024d, new GammaParticle(511000.0, 0.00243)), new(0.28800000000000003d, new GammaParticle(8810.0, 0.14073)), new(0.309d, new GammaParticle(52965.0, 0.02341)), new(0.542d, new GammaParticle(54070.0, 0.02293)), new(0.17800000000000002d, new GammaParticle(61387.0, 0.0202)), new(0.225d, new GammaParticle(62084.0, 0.01997)), new(0.0471d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.000000000000810525d },
            { 200.0d, 0.00000000000181578d },
            { 300.0d, 0.00000000000301576d },
            { 400.0d, 0.00000000000441048d },
            { 500.0d, 0.00000000000599992d },
            { 600.0d, 0.0000000000077841d },
            { 700.0d, 0.000000000009763d },
            { 800.0d, 0.0000000000119366d },
            { 900.0d, 0.000000000014329d },
            { 1000.0d, 0.0000000000169257d },
            { 1500.0d, 0.0000000000334501d },
            { 2000.0d, 0.0000000000559568d },
            { 2500.0d, 0.0000000000880613d },
            { 3000.0d, 0.000000000129101d },
            { 3500.0d, 0.00000000018269d },
            { 4000.0d, 0.000000000248188d },
            { 4500.0d, 0.000000000329395d },
            { 5000.0d, 0.000000000425608d },
            { 5500.0d, 0.000000000540701d },
            { 6000.0d, 0.000000000673937d },
            { 6500.0d, 0.000000000829211d },
            { 7000.0d, 0.00000000100575d },
            { 7500.0d, 0.00000000120739d },
            { 8000.0d, 0.00000000143334d },
            { 8500.0d, 0.00000000168735d },
            { 9000.0d, 0.00000000196861d },
            { 9500.0d, 0.0000000022807d },
            { 10000.0d, 0.00000000262284d },
            { 11000.0d, 0.00000000340665d },
            { 12000.0d, 0.00000000432992d },
            { 13000.0d, 0.00000000540167d },
            { 14000.0d, 0.00000000663009d },
            { 15000.0d, 0.00000000802249d },
            { 16000.0d, 0.00000000958527d },
            { 17000.0d, 0.000000011324d },
            { 18000.0d, 0.0000000132433d },
            { 19000.0d, 0.000000015347d },
            { 20000.0d, 0.0000000176381d },
            { 21000.0d, 0.0000000201189d },
            { 22000.0d, 0.0000000227908d },
            { 23000.0d, 0.0000000256546d },
            { 24000.0d, 0.0000000287104d },
            { 25000.0d, 0.0000000319576d },
            { 26000.0d, 0.0000000353953d },
            { 27000.0d, 0.0000000390215d },
            { 28000.0d, 0.0000000428343d },
            { 29000.0d, 0.0000000468308d },
            { 30000.0d, 0.0000000510081d },
            { 31000.0d, 0.0000000553626d },
            { 32000.0d, 0.0000000598906d },
            { 33000.0d, 0.0000000645878d },
            { 34000.0d, 0.0000000694499d },
            { 35000.0d, 0.0000000744718d },
            { 36000.0d, 0.0000000796489d },
            { 37000.0d, 0.0000000849758d },
            { 38000.0d, 0.0000000904473d },
            { 39000.0d, 0.0000000960578d },
            { 40000.0d, 0.000000101802d },
            { 41000.0d, 0.000000107673d },
            { 42000.0d, 0.000000113667d },
            { 43000.0d, 0.000000119776d },
            { 44000.0d, 0.000000125994d },
            { 45000.0d, 0.000000132317d },
            { 46000.0d, 0.000000138738d },
            { 47000.0d, 0.00000014525d },
            { 48000.0d, 0.000000151847d },
            { 49000.0d, 0.000000158525d },
            { 50000.0d, 0.000000165276d },
            { 51000.0d, 0.000000172095d },
            { 52000.0d, 0.000000178975d },
            { 53000.0d, 0.000000185911d },
            { 54000.0d, 0.000000192897d },
            { 55000.0d, 0.000000199928d },
            { 56000.0d, 0.000000206997d },
            { 57000.0d, 0.0000002141d },
            { 58000.0d, 0.00000022123d },
            { 59000.0d, 0.000000228382d },
            { 60000.0d, 0.000000235552d },
            { 61000.0d, 0.000000242733d },
            { 62000.0d, 0.000000249921d },
            { 63000.0d, 0.000000257109d },
            { 64000.0d, 0.000000264297d },
            { 65000.0d, 0.000000271475d },
            { 66000.0d, 0.000000278642d },
            { 67000.0d, 0.000000285791d },
            { 68000.0d, 0.00000029292d },
            { 69000.0d, 0.000000300021d },
            { 70000.0d, 0.000000307095d },
            { 71000.0d, 0.000000314134d },
            { 72000.0d, 0.000000321137d },
            { 73000.0d, 0.000000328098d },
            { 74000.0d, 0.000000335014d },
            { 75000.0d, 0.000000341881d },
            { 76000.0d, 0.000000348698d },
            { 77000.0d, 0.000000355459d },
            { 78000.0d, 0.000000362162d },
            { 79000.0d, 0.000000368805d },
            { 80000.0d, 0.000000375384d },
            { 81000.0d, 0.000000381896d },
            { 82000.0d, 0.000000388338d },
            { 83000.0d, 0.000000394709d },
            { 84000.0d, 0.000000401007d },
            { 85000.0d, 0.000000407229d },
            { 86000.0d, 0.000000413371d },
            { 87000.0d, 0.000000419434d },
            { 88000.0d, 0.000000425414d },
            { 89000.0d, 0.00000043131d },
            { 90000.0d, 0.000000437121d },
            { 91000.0d, 0.000000442845d },
            { 92000.0d, 0.000000448481d },
            { 93000.0d, 0.000000454025d },
            { 94000.0d, 0.00000045948d },
            { 95000.0d, 0.000000464842d },
            { 96000.0d, 0.000000470111d },
            { 97000.0d, 0.000000475287d },
            { 98000.0d, 0.000000480366d },
            { 99000.0d, 0.000000485352d },
            { 100000.0d, 0.000000490241d },
            { 101000.0d, 0.000000495034d },
            { 102000.0d, 0.00000049973d },
            { 103000.0d, 0.000000504329d },
            { 104000.0d, 0.00000050883d },
            { 105000.0d, 0.000000513235d },
            { 106000.0d, 0.000000517542d },
            { 107000.0d, 0.000000521753d },
            { 108000.0d, 0.000000525866d },
            { 109000.0d, 0.000000529884d },
            { 110000.0d, 0.000000533804d },
            { 111000.0d, 0.000000537629d },
            { 112000.0d, 0.000000541359d },
            { 113000.0d, 0.000000544995d },
            { 114000.0d, 0.000000548538d },
            { 115000.0d, 0.000000551987d },
            { 116000.0d, 0.000000555343d },
            { 117000.0d, 0.00000055861d },
            { 118000.0d, 0.000000561786d },
            { 119000.0d, 0.000000564873d },
            { 120000.0d, 0.000000567873d },
            { 121000.0d, 0.000000570787d },
            { 122000.0d, 0.000000573616d },
            { 123000.0d, 0.000000576361d },
            { 124000.0d, 0.000000579024d },
            { 125000.0d, 0.000000581607d },
            { 126000.0d, 0.000000584111d },
            { 127000.0d, 0.000000586539d },
            { 128000.0d, 0.000000588891d },
            { 129000.0d, 0.00000059117d },
            { 130000.0d, 0.000000593377d },
            { 131000.0d, 0.000000595514d },
            { 132000.0d, 0.000000597584d },
            { 133000.0d, 0.000000599589d },
            { 134000.0d, 0.000000601532d },
            { 135000.0d, 0.000000603413d },
            { 136000.0d, 0.000000605235d },
            { 137000.0d, 0.000000607001d },
            { 138000.0d, 0.000000608713d },
            { 139000.0d, 0.000000610374d },
            { 140000.0d, 0.000000611985d },
            { 141000.0d, 0.00000061355d },
            { 142000.0d, 0.000000615072d },
            { 143000.0d, 0.000000616553d },
            { 144000.0d, 0.000000617983d },
            { 145000.0d, 0.000000619351d },
            { 146000.0d, 0.00000062066d },
            { 147000.0d, 0.000000621907d },
            { 148000.0d, 0.000000623099d },
            { 149000.0d, 0.000000624233d },
            { 150000.0d, 0.000000625315d },
            { 151000.0d, 0.000000626346d },
            { 152000.0d, 0.000000627328d },
            { 153000.0d, 0.000000628258d },
            { 154000.0d, 0.000000629104d },
            { 155000.0d, 0.000000629853d },
            { 156000.0d, 0.000000630506d },
            { 157000.0d, 0.000000631062d },
            { 158000.0d, 0.000000631523d },
            { 159000.0d, 0.000000631889d },
            { 160000.0d, 0.000000632159d },
            { 161000.0d, 0.000000632335d },
            { 162000.0d, 0.000000632416d },
            { 163000.0d, 0.000000632403d },
            { 164000.0d, 0.000000632298d },
            { 165000.0d, 0.0000006321d },
            { 166000.0d, 0.000000631809d },
            { 167000.0d, 0.000000631426d },
            { 168000.0d, 0.000000630952d },
            { 169000.0d, 0.000000630388d },
            { 170000.0d, 0.000000629733d },
            { 171000.0d, 0.000000628988d },
            { 172000.0d, 0.000000628155d },
            { 173000.0d, 0.000000627234d },
            { 174000.0d, 0.000000626225d },
            { 175000.0d, 0.000000625129d },
            { 176000.0d, 0.000000623946d },
            { 177000.0d, 0.000000622679d },
            { 178000.0d, 0.000000621326d },
            { 179000.0d, 0.000000619889d },
            { 180000.0d, 0.000000618369d },
            { 181000.0d, 0.000000616766d },
            { 182000.0d, 0.000000615081d },
            { 183000.0d, 0.000000613315d },
            { 184000.0d, 0.000000611469d },
            { 185000.0d, 0.000000609544d },
            { 186000.0d, 0.000000607541d },
            { 187000.0d, 0.000000605459d },
            { 188000.0d, 0.0000006033d },
            { 189000.0d, 0.000000601067d },
            { 190000.0d, 0.000000598758d },
            { 191000.0d, 0.000000596375d },
            { 192000.0d, 0.000000593917d },
            { 193000.0d, 0.000000591389d },
            { 194000.0d, 0.000000588789d },
            { 195000.0d, 0.000000586119d },
            { 196000.0d, 0.000000583379d },
            { 197000.0d, 0.000000580572d },
            { 198000.0d, 0.000000577696d },
            { 199000.0d, 0.000000574755d },
            { 200000.0d, 0.000000571749d },
            { 201000.0d, 0.000000568677d },
            { 202000.0d, 0.000000565543d },
            { 203000.0d, 0.000000562347d },
            { 204000.0d, 0.00000055909d },
            { 205000.0d, 0.000000555773d },
            { 206000.0d, 0.000000552397d },
            { 207000.0d, 0.000000548963d },
            { 208000.0d, 0.000000545473d },
            { 209000.0d, 0.000000541927d },
            { 210000.0d, 0.000000538327d },
            { 211000.0d, 0.000000534674d },
            { 212000.0d, 0.000000530968d },
            { 213000.0d, 0.000000527212d },
            { 214000.0d, 0.000000523407d },
            { 215000.0d, 0.000000519552d },
            { 216000.0d, 0.000000515651d },
            { 217000.0d, 0.000000511704d },
            { 218000.0d, 0.000000507712d },
            { 219000.0d, 0.000000503676d },
            { 220000.0d, 0.000000499598d },
            { 221000.0d, 0.000000495479d },
            { 222000.0d, 0.000000491321d },
            { 223000.0d, 0.000000487124d },
            { 224000.0d, 0.00000048289d },
            { 225000.0d, 0.000000478619d },
            { 226000.0d, 0.000000474314d },
            { 227000.0d, 0.000000469975d },
            { 228000.0d, 0.000000465605d },
            { 229000.0d, 0.000000461205d },
            { 230000.0d, 0.000000456775d },
            { 231000.0d, 0.000000452316d },
            { 232000.0d, 0.000000447831d },
            { 233000.0d, 0.000000443321d },
            { 234000.0d, 0.000000438787d },
            { 235000.0d, 0.00000043423d },
            { 236000.0d, 0.000000429653d },
            { 237000.0d, 0.000000425056d },
            { 238000.0d, 0.000000420439d },
            { 239000.0d, 0.000000415807d },
            { 240000.0d, 0.000000411158d },
            { 241000.0d, 0.000000406496d },
            { 242000.0d, 0.000000401821d },
            { 243000.0d, 0.000000397134d },
            { 244000.0d, 0.000000392438d },
            { 245000.0d, 0.000000387733d },
            { 246000.0d, 0.000000383022d },
            { 247000.0d, 0.000000378305d },
            { 248000.0d, 0.000000373584d },
            { 249000.0d, 0.000000368861d },
            { 250000.0d, 0.000000364137d },
            { 251000.0d, 0.000000359413d },
            { 252000.0d, 0.000000354691d },
            { 253000.0d, 0.000000349973d },
            { 254000.0d, 0.000000345259d },
            { 255000.0d, 0.000000340552d },
            { 256000.0d, 0.000000335854d },
            { 257000.0d, 0.000000331165d },
            { 258000.0d, 0.000000326486d },
            { 259000.0d, 0.000000321821d },
            { 260000.0d, 0.00000031717d },
            { 261000.0d, 0.000000312535d },
            { 262000.0d, 0.000000307917d },
            { 263000.0d, 0.000000303318d },
            { 264000.0d, 0.000000298739d },
            { 265000.0d, 0.000000294182d },
            { 266000.0d, 0.000000289649d },
            { 267000.0d, 0.000000285142d },
            { 268000.0d, 0.000000280661d },
            { 269000.0d, 0.000000276209d },
            { 270000.0d, 0.000000271786d },
            { 271000.0d, 0.000000267396d },
            { 272000.0d, 0.000000263038d },
            { 273000.0d, 0.000000258716d },
            { 274000.0d, 0.00000025443d },
            { 275000.0d, 0.000000250183d },
            { 276000.0d, 0.000000245974d },
            { 277000.0d, 0.000000241808d },
            { 278000.0d, 0.000000237685d },
            { 279000.0d, 0.000000233606d },
            { 280000.0d, 0.000000229574d },
            { 281000.0d, 0.00000022559d },
            { 282000.0d, 0.000000221656d },
            { 283000.0d, 0.000000217772d },
            { 284000.0d, 0.000000213943d },
            { 285000.0d, 0.000000210168d },
            { 286000.0d, 0.000000206449d },
            { 287000.0d, 0.000000202789d },
            { 288000.0d, 0.000000199189d },
            { 289000.0d, 0.00000019565d },
            { 290000.0d, 0.000000192174d },
            { 291000.0d, 0.000000188764d },
            { 292000.0d, 0.00000018542d },
            { 293000.0d, 0.000000182145d },
            { 294000.0d, 0.000000178939d },
            { 295000.0d, 0.000000175807d },
            { 296000.0d, 0.000000172747d },
            { 297000.0d, 0.000000169763d },
            { 298000.0d, 0.000000166856d },
            { 299000.0d, 0.000000164028d },
            { 300000.0d, 0.000000161281d },
            { 301000.0d, 0.000000158616d },
            { 302000.0d, 0.000000156034d },
            { 303000.0d, 0.000000153539d },
            { 304000.0d, 0.000000151131d },
            { 305000.0d, 0.000000148814d },
            { 306000.0d, 0.000000146587d },
            { 307000.0d, 0.000000144453d },
            { 308000.0d, 0.000000142414d },
            { 309000.0d, 0.000000140471d },
            { 310000.0d, 0.000000138628d },
            { 311000.0d, 0.000000136882d },
            { 312000.0d, 0.000000135241d },
            { 313000.0d, 0.000000133701d },
            { 314000.0d, 0.000000132268d },
            { 315000.0d, 0.000000130936d },
            { 316000.0d, 0.000000129626d },
            { 317000.0d, 0.000000128314d },
            { 318000.0d, 0.000000126997d },
            { 319000.0d, 0.000000125678d },
            { 320000.0d, 0.000000124355d },
            { 321000.0d, 0.000000123029d },
            { 322000.0d, 0.000000121701d },
            { 323000.0d, 0.00000012037d },
            { 324000.0d, 0.000000119036d },
            { 325000.0d, 0.0000001177d },
            { 326000.0d, 0.000000116363d },
            { 327000.0d, 0.000000115023d },
            { 328000.0d, 0.000000113682d },
            { 329000.0d, 0.00000011234d },
            { 330000.0d, 0.000000110996d },
            { 331000.0d, 0.000000109651d },
            { 332000.0d, 0.000000108305d },
            { 333000.0d, 0.000000106958d },
            { 334000.0d, 0.000000105611d },
            { 335000.0d, 0.000000104264d },
            { 336000.0d, 0.000000102916d },
            { 337000.0d, 0.000000101569d },
            { 338000.0d, 0.000000100221d },
            { 339000.0d, 0.0000000988744d },
            { 340000.0d, 0.0000000975282d },
            { 341000.0d, 0.0000000961827d },
            { 342000.0d, 0.0000000948383d },
            { 343000.0d, 0.0000000934951d },
            { 344000.0d, 0.0000000921533d },
            { 345000.0d, 0.0000000908131d },
            { 346000.0d, 0.0000000894747d },
            { 347000.0d, 0.0000000881382d },
            { 348000.0d, 0.000000086804d },
            { 349000.0d, 0.0000000854721d },
            { 350000.0d, 0.0000000841428d },
            { 351000.0d, 0.0000000828162d },
            { 352000.0d, 0.0000000814927d },
            { 353000.0d, 0.0000000801723d },
            { 354000.0d, 0.0000000788552d },
            { 355000.0d, 0.0000000775418d },
            { 356000.0d, 0.0000000762321d },
            { 357000.0d, 0.0000000749264d },
            { 358000.0d, 0.0000000736248d },
            { 359000.0d, 0.0000000723276d },
            { 360000.0d, 0.000000071035d },
            { 361000.0d, 0.0000000697472d },
            { 362000.0d, 0.0000000684643d },
            { 363000.0d, 0.0000000671867d },
            { 364000.0d, 0.0000000659144d },
            { 365000.0d, 0.0000000646477d },
            { 366000.0d, 0.0000000633868d },
            { 367000.0d, 0.0000000621319d },
            { 368000.0d, 0.0000000608832d },
            { 369000.0d, 0.0000000596409d },
            { 370000.0d, 0.0000000584053d },
            { 371000.0d, 0.0000000571764d },
            { 372000.0d, 0.0000000559546d },
            { 373000.0d, 0.0000000547401d },
            { 374000.0d, 0.0000000535329d },
            { 375000.0d, 0.0000000523335d },
            { 376000.0d, 0.0000000511419d },
            { 377000.0d, 0.0000000499584d },
            { 378000.0d, 0.0000000487831d },
            { 379000.0d, 0.0000000476164d },
            { 380000.0d, 0.0000000464584d },
            { 381000.0d, 0.0000000453093d },
            { 382000.0d, 0.0000000441693d },
            { 383000.0d, 0.0000000430386d },
            { 384000.0d, 0.0000000419175d },
            { 385000.0d, 0.0000000408062d },
            { 386000.0d, 0.0000000397049d },
            { 387000.0d, 0.0000000386137d },
            { 388000.0d, 0.0000000375329d },
            { 389000.0d, 0.0000000364628d },
            { 390000.0d, 0.0000000354035d },
            { 391000.0d, 0.0000000343553d },
            { 392000.0d, 0.0000000333183d },
            { 393000.0d, 0.0000000322928d },
            { 394000.0d, 0.000000031279d },
            { 395000.0d, 0.0000000302771d },
            { 396000.0d, 0.0000000292873d },
            { 397000.0d, 0.0000000283099d },
            { 398000.0d, 0.0000000273451d },
            { 399000.0d, 0.000000026393d },
            { 400000.0d, 0.000000025454d },
            { 401000.0d, 0.0000000245281d },
            { 402000.0d, 0.0000000236157d },
            { 403000.0d, 0.000000022717d },
            { 404000.0d, 0.0000000218321d },
            { 405000.0d, 0.0000000209614d },
            { 406000.0d, 0.0000000201049d },
            { 407000.0d, 0.0000000192631d },
            { 408000.0d, 0.0000000184359d },
            { 409000.0d, 0.0000000176238d },
            { 410000.0d, 0.0000000168268d },
            { 411000.0d, 0.0000000160453d },
            { 412000.0d, 0.0000000152794d },
            { 413000.0d, 0.0000000145295d },
            { 414000.0d, 0.0000000137956d },
            { 415000.0d, 0.000000013078d },
            { 416000.0d, 0.000000012377d },
            { 417000.0d, 0.0000000116927d },
            { 418000.0d, 0.0000000110254d },
            { 419000.0d, 0.0000000103754d },
            { 420000.0d, 0.00000000974278d },
            { 421000.0d, 0.00000000912785d },
            { 422000.0d, 0.00000000853081d },
            { 423000.0d, 0.00000000795189d },
            { 424000.0d, 0.00000000739131d },
            { 425000.0d, 0.00000000684931d },
            { 426000.0d, 0.00000000632611d },
            { 427000.0d, 0.00000000582194d },
            { 428000.0d, 0.00000000533702d },
            { 429000.0d, 0.00000000487158d },
            { 430000.0d, 0.00000000442585d },
            { 431000.0d, 0.00000000400006d },
            { 432000.0d, 0.00000000359444d },
            { 433000.0d, 0.0000000032092d },
            { 434000.0d, 0.00000000284459d },
            { 435000.0d, 0.00000000250083d },
            { 436000.0d, 0.00000000217815d },
            { 437000.0d, 0.00000000187678d },
            { 438000.0d, 0.00000000159694d },
            { 439000.0d, 0.00000000133887d },
            { 440000.0d, 0.00000000110279d },
            { 441000.0d, 0.000000000888937d },
            { 442000.0d, 0.00000000069753d },
            { 443000.0d, 0.000000000528801d },
            { 444000.0d, 0.000000000382975d },
            { 445000.0d, 0.000000000260279d },
            { 446000.0d, 0.000000000160937d },
            { 447000.0d, 0.0000000000851703d },
            { 448000.0d, 0.0000000000331969d },
            { 449000.0d, 0.000000000005225d },
            { 449657.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    