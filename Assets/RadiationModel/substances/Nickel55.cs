using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel55 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel55";
        public override double halfLife { get; } = 0.2037d;
        public override double atomicWeight { get; } = 54.95133d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron55()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.9980000000000002d, new GammaParticle(511000.0, 0.00243)), new(1.0047384e-05d, new GammaParticle(800.0, 1.5498)), new(0.0001056597603227269d, new GammaParticle(6915.0, 0.1793)), new(0.00020652806943457174d, new GammaParticle(6930.0, 0.17891)), new(4.283217024270137e-05d, new GammaParticle(7677.0, 0.1615)), new(4.283217024270137e-05d, new GammaParticle(7677.0, 0.1615)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 25000.0d, 0.0000008643d },
            { 50000.0d, 0.00000250648d },
            { 75000.0d, 0.00000428519d },
            { 100000.0d, 0.00000609145d },
            { 125000.0d, 0.00000790532d },
            { 150000.0d, 0.00000972528d },
            { 175000.0d, 0.0000115539d },
            { 200000.0d, 0.0000133944d },
            { 225000.0d, 0.0000152493d },
            { 250000.0d, 0.0000171207d },
            { 275000.0d, 0.0000190103d },
            { 300000.0d, 0.000020919d },
            { 325000.0d, 0.0000228476d },
            { 350000.0d, 0.0000247966d },
            { 375000.0d, 0.0000267659d },
            { 400000.0d, 0.0000287557d },
            { 425000.0d, 0.0000307658d },
            { 450000.0d, 0.0000327958d },
            { 475000.0d, 0.0000348454d },
            { 500000.0d, 0.000036914d },
            { 525000.0d, 0.0000390011d },
            { 550000.0d, 0.0000411061d },
            { 575000.0d, 0.0000432284d },
            { 600000.0d, 0.0000453673d },
            { 625000.0d, 0.0000475221d },
            { 650000.0d, 0.0000496921d },
            { 675000.0d, 0.0000518764d },
            { 700000.0d, 0.0000540745d },
            { 725000.0d, 0.0000562854d },
            { 750000.0d, 0.0000585084d },
            { 775000.0d, 0.0000607428d },
            { 800000.0d, 0.0000629878d },
            { 825000.0d, 0.0000652425d },
            { 850000.0d, 0.0000675062d },
            { 875000.0d, 0.0000697782d },
            { 900000.0d, 0.0000720575d },
            { 925000.0d, 0.0000743434d },
            { 950000.0d, 0.0000766352d },
            { 975000.0d, 0.0000789321d },
            { 1000000.0d, 0.0000812333d },
            { 1025000.0d, 0.000083538d },
            { 1050000.0d, 0.0000858455d },
            { 1075000.0d, 0.000088155d },
            { 1100000.0d, 0.0000904658d },
            { 1125000.0d, 0.0000927771d },
            { 1150000.0d, 0.0000950882d },
            { 1175000.0d, 0.0000973983d },
            { 1200000.0d, 0.0000997067d },
            { 1225000.0d, 0.000102013d },
            { 1250000.0d, 0.000104316d },
            { 1275000.0d, 0.000106615d },
            { 1300000.0d, 0.000108909d },
            { 1325000.0d, 0.000111199d },
            { 1350000.0d, 0.000113482d },
            { 1375000.0d, 0.000115759d },
            { 1400000.0d, 0.000118029d },
            { 1425000.0d, 0.000120291d },
            { 1450000.0d, 0.000122544d },
            { 1475000.0d, 0.000124789d },
            { 1500000.0d, 0.000127023d },
            { 1525000.0d, 0.000129247d },
            { 1550000.0d, 0.00013146d },
            { 1575000.0d, 0.000133661d },
            { 1600000.0d, 0.00013585d },
            { 1625000.0d, 0.000138026d },
            { 1650000.0d, 0.000140188d },
            { 1675000.0d, 0.000142337d },
            { 1700000.0d, 0.000144471d },
            { 1725000.0d, 0.000146589d },
            { 1750000.0d, 0.000148692d },
            { 1775000.0d, 0.000150779d },
            { 1800000.0d, 0.000152849d },
            { 1825000.0d, 0.000154901d },
            { 1850000.0d, 0.000156936d },
            { 1875000.0d, 0.000158952d },
            { 1900000.0d, 0.000160949d },
            { 1925000.0d, 0.000162927d },
            { 1950000.0d, 0.000164885d },
            { 1975000.0d, 0.000166822d },
            { 2000000.0d, 0.000168739d },
            { 2025000.0d, 0.000170634d },
            { 2050000.0d, 0.000172508d },
            { 2075000.0d, 0.000174359d },
            { 2100000.0d, 0.000176188d },
            { 2125000.0d, 0.000177993d },
            { 2150000.0d, 0.000179775d },
            { 2175000.0d, 0.000181533d },
            { 2200000.0d, 0.000183266d },
            { 2225000.0d, 0.000184975d },
            { 2250000.0d, 0.000186658d },
            { 2275000.0d, 0.000188316d },
            { 2300000.0d, 0.000189948d },
            { 2325000.0d, 0.000191553d },
            { 2350000.0d, 0.000193132d },
            { 2375000.0d, 0.000194683d },
            { 2400000.0d, 0.000196208d },
            { 2425000.0d, 0.000197704d },
            { 2450000.0d, 0.000199173d },
            { 2475000.0d, 0.000200613d },
            { 2500000.0d, 0.000202024d },
            { 2525000.0d, 0.000203406d },
            { 2550000.0d, 0.000204759d },
            { 2575000.0d, 0.000206082d },
            { 2600000.0d, 0.000207375d },
            { 2625000.0d, 0.000208638d },
            { 2650000.0d, 0.000209871d },
            { 2675000.0d, 0.000211072d },
            { 2700000.0d, 0.000212243d },
            { 2725000.0d, 0.000213383d },
            { 2750000.0d, 0.000214491d },
            { 2775000.0d, 0.000215567d },
            { 2800000.0d, 0.000216611d },
            { 2825000.0d, 0.000217623d },
            { 2850000.0d, 0.000218603d },
            { 2875000.0d, 0.00021955d },
            { 2900000.0d, 0.000220465d },
            { 2925000.0d, 0.000221346d },
            { 2950000.0d, 0.000222195d },
            { 2975000.0d, 0.00022301d },
            { 3000000.0d, 0.000223791d },
            { 3025000.0d, 0.000224539d },
            { 3050000.0d, 0.000225253d },
            { 3075000.0d, 0.000225934d },
            { 3100000.0d, 0.00022658d },
            { 3125000.0d, 0.000227192d },
            { 3150000.0d, 0.00022777d },
            { 3175000.0d, 0.000228313d },
            { 3200000.0d, 0.000228822d },
            { 3225000.0d, 0.000229297d },
            { 3250000.0d, 0.000229736d },
            { 3275000.0d, 0.000230141d },
            { 3300000.0d, 0.000230511d },
            { 3325000.0d, 0.000230847d },
            { 3350000.0d, 0.000231147d },
            { 3375000.0d, 0.000231413d },
            { 3400000.0d, 0.000231643d },
            { 3425000.0d, 0.000231838d },
            { 3450000.0d, 0.000231999d },
            { 3475000.0d, 0.000232124d },
            { 3500000.0d, 0.000232214d },
            { 3525000.0d, 0.000232269d },
            { 3550000.0d, 0.000232289d },
            { 3575000.0d, 0.000232274d },
            { 3600000.0d, 0.000232224d },
            { 3625000.0d, 0.000232139d },
            { 3650000.0d, 0.000232019d },
            { 3675000.0d, 0.000231863d },
            { 3700000.0d, 0.000231674d },
            { 3725000.0d, 0.000231449d },
            { 3750000.0d, 0.000231189d },
            { 3775000.0d, 0.000230895d },
            { 3800000.0d, 0.000230566d },
            { 3825000.0d, 0.000230203d },
            { 3850000.0d, 0.000229806d },
            { 3875000.0d, 0.000229374d },
            { 3900000.0d, 0.000228908d },
            { 3925000.0d, 0.000228407d },
            { 3950000.0d, 0.000227873d },
            { 3975000.0d, 0.000227305d },
            { 4000000.0d, 0.000226704d },
            { 4025000.0d, 0.000226069d },
            { 4050000.0d, 0.000225401d },
            { 4075000.0d, 0.000224699d },
            { 4100000.0d, 0.000223964d },
            { 4125000.0d, 0.000223197d },
            { 4150000.0d, 0.000222397d },
            { 4175000.0d, 0.000221565d },
            { 4200000.0d, 0.0002207d },
            { 4225000.0d, 0.000219803d },
            { 4250000.0d, 0.000218875d },
            { 4275000.0d, 0.000217915d },
            { 4300000.0d, 0.000216924d },
            { 4325000.0d, 0.000215901d },
            { 4350000.0d, 0.000214848d },
            { 4375000.0d, 0.000213764d },
            { 4400000.0d, 0.00021265d },
            { 4425000.0d, 0.000211505d },
            { 4450000.0d, 0.000210331d },
            { 4475000.0d, 0.000209128d },
            { 4500000.0d, 0.000207895d },
            { 4525000.0d, 0.000206634d },
            { 4550000.0d, 0.000205343d },
            { 4575000.0d, 0.000204025d },
            { 4600000.0d, 0.000202679d },
            { 4625000.0d, 0.000201305d },
            { 4650000.0d, 0.000199903d },
            { 4675000.0d, 0.000198475d },
            { 4700000.0d, 0.00019702d },
            { 4725000.0d, 0.000195539d },
            { 4750000.0d, 0.000194032d },
            { 4775000.0d, 0.0001925d },
            { 4800000.0d, 0.000190943d },
            { 4825000.0d, 0.000189361d },
            { 4850000.0d, 0.000187754d },
            { 4875000.0d, 0.000186124d },
            { 4900000.0d, 0.00018447d },
            { 4925000.0d, 0.000182794d },
            { 4950000.0d, 0.000181094d },
            { 4975000.0d, 0.000179373d },
            { 5000000.0d, 0.000177629d },
            { 5025000.0d, 0.000175865d },
            { 5050000.0d, 0.000174079d },
            { 5075000.0d, 0.000172273d },
            { 5100000.0d, 0.000170447d },
            { 5125000.0d, 0.000168602d },
            { 5150000.0d, 0.000166738d },
            { 5175000.0d, 0.000164856d },
            { 5200000.0d, 0.000162955d },
            { 5225000.0d, 0.000161037d },
            { 5250000.0d, 0.000159102d },
            { 5275000.0d, 0.000157151d },
            { 5300000.0d, 0.000155184d },
            { 5325000.0d, 0.000153201d },
            { 5350000.0d, 0.000151204d },
            { 5375000.0d, 0.000149192d },
            { 5400000.0d, 0.000147167d },
            { 5425000.0d, 0.000145129d },
            { 5450000.0d, 0.000143078d },
            { 5475000.0d, 0.000141015d },
            { 5500000.0d, 0.000138941d },
            { 5525000.0d, 0.000136857d },
            { 5550000.0d, 0.000134762d },
            { 5575000.0d, 0.000132657d },
            { 5600000.0d, 0.000130543d },
            { 5625000.0d, 0.000128422d },
            { 5650000.0d, 0.000126292d },
            { 5675000.0d, 0.000124156d },
            { 5700000.0d, 0.000122013d },
            { 5725000.0d, 0.000119864d },
            { 5750000.0d, 0.000117711d },
            { 5775000.0d, 0.000115553d },
            { 5800000.0d, 0.000113391d },
            { 5825000.0d, 0.000111226d },
            { 5850000.0d, 0.000109059d },
            { 5875000.0d, 0.00010689d },
            { 5900000.0d, 0.00010472d },
            { 5925000.0d, 0.00010255d },
            { 5950000.0d, 0.000100381d },
            { 5975000.0d, 0.0000982126d },
            { 6000000.0d, 0.0000960462d },
            { 6025000.0d, 0.0000938826d },
            { 6050000.0d, 0.0000917223d },
            { 6075000.0d, 0.0000895663d },
            { 6100000.0d, 0.0000874152d },
            { 6125000.0d, 0.0000852698d },
            { 6150000.0d, 0.000083131d },
            { 6175000.0d, 0.0000809993d },
            { 6200000.0d, 0.0000788758d },
            { 6225000.0d, 0.0000767611d },
            { 6250000.0d, 0.0000746561d },
            { 6275000.0d, 0.0000725616d },
            { 6300000.0d, 0.0000704783d },
            { 6325000.0d, 0.0000684072d },
            { 6350000.0d, 0.000066349d },
            { 6375000.0d, 0.0000643046d },
            { 6400000.0d, 0.0000622749d },
            { 6425000.0d, 0.0000602606d },
            { 6450000.0d, 0.0000582627d },
            { 6475000.0d, 0.000056282d },
            { 6500000.0d, 0.0000543193d },
            { 6525000.0d, 0.0000523757d },
            { 6550000.0d, 0.0000504519d },
            { 6575000.0d, 0.0000485488d },
            { 6600000.0d, 0.0000466673d },
            { 6625000.0d, 0.0000448085d },
            { 6650000.0d, 0.000042973d },
            { 6675000.0d, 0.000041162d },
            { 6700000.0d, 0.0000393762d },
            { 6725000.0d, 0.0000376167d },
            { 6750000.0d, 0.0000358844d },
            { 6775000.0d, 0.0000341802d },
            { 6800000.0d, 0.0000325051d },
            { 6825000.0d, 0.00003086d },
            { 6850000.0d, 0.0000292459d },
            { 6875000.0d, 0.0000276638d },
            { 6900000.0d, 0.0000261147d },
            { 6925000.0d, 0.0000245994d },
            { 6950000.0d, 0.0000231191d },
            { 6975000.0d, 0.0000216747d },
            { 7000000.0d, 0.0000202672d },
            { 7025000.0d, 0.0000188976d },
            { 7050000.0d, 0.000017567d },
            { 7075000.0d, 0.0000162763d },
            { 7100000.0d, 0.0000150266d },
            { 7125000.0d, 0.0000138189d },
            { 7150000.0d, 0.0000126543d },
            { 7175000.0d, 0.0000115337d },
            { 7200000.0d, 0.0000104582d },
            { 7225000.0d, 0.00000942894d },
            { 7250000.0d, 0.00000844687d },
            { 7275000.0d, 0.00000751307d },
            { 7300000.0d, 0.00000662861d },
            { 7325000.0d, 0.00000579454d },
            { 7350000.0d, 0.00000501194d },
            { 7375000.0d, 0.00000428187d },
            { 7400000.0d, 0.0000036054d },
            { 7425000.0d, 0.00000298359d },
            { 7450000.0d, 0.00000241751d },
            { 7475000.0d, 0.00000190822d },
            { 7500000.0d, 0.00000145679d },
            { 7525000.0d, 0.00000106426d },
            { 7550000.0d, 0.000000731671d },
            { 7575000.0d, 0.000000460038d },
            { 7600000.0d, 0.000000250344d },
            { 7625000.0d, 0.000000103517d },
            { 7650000.0d, 0.000000020364d },
            { 7670000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    