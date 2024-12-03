using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium94m";
        public override double halfLife { get; } = 3120.0d;
        public override double atomicWeight { get; } = 93.90973d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium94()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.9420000000000001d, new GammaParticle(871050.0, 0.00142)), new(0.0079128d, new GammaParticle(875100.0, 0.00142)), new(0.022136999999999997d, new GammaParticle(993190.0, 0.00125)), new(0.0021666d, new GammaParticle(998200.0, 0.00124)), new(0.0015072d, new GammaParticle(1005800.0, 0.00123)), new(0.0027318d, new GammaParticle(1022200.0, 0.00121)), new(0.00044274d, new GammaParticle(1037200.0, 0.0012)), new(0.00042389999999999995d, new GammaParticle(1101300.0, 0.00113)), new(0.007536d, new GammaParticle(1196400.0, 0.00104)), new(0.0021666d, new GammaParticle(1264900.0, 0.00098)), new(0.001884d, new GammaParticle(1357400.0, 0.00091)), new(0.00058404d, new GammaParticle(1499000.0, 0.00083)), new(0.045216000000000006d, new GammaParticle(1522100.0, 0.00081)), new(0.00034854000000000005d, new GammaParticle(1670100.0, 0.00074)), new(0.0015072d, new GammaParticle(1757900.0, 0.00071)), new(0.0001884d, new GammaParticle(1769900.0, 0.0007)), new(0.002355d, new GammaParticle(1864000.0, 0.00067)), new(0.057462d, new GammaParticle(1868680.0, 0.00066)), new(0.0008477999999999999d, new GammaParticle(1928800.0, 0.00064)), new(0.0002355d, new GammaParticle(2027500.0, 0.00061)), new(0.0008477999999999999d, new GammaParticle(2067400.0, 0.0006)), new(0.00052752d, new GammaParticle(2257500.0, 0.00055)), new(0.00049926d, new GammaParticle(2292200.0, 0.00054)), new(0.00471d, new GammaParticle(2393200.0, 0.00052)), new(0.0031086000000000004d, new GammaParticle(2529800.0, 0.00049)), new(0.0012246d, new GammaParticle(2577200.0, 0.00048)), new(0.00034854000000000005d, new GammaParticle(2641600.0, 0.00047)), new(0.0006594d, new GammaParticle(2664100.0, 0.00047)), new(0.0352308d, new GammaParticle(2740100.0, 0.00045)), new(0.00020724d, new GammaParticle(2869900.0, 0.00043)), new(0.0007536d, new GammaParticle(3021600.0, 0.00041)), new(0.00011304d, new GammaParticle(3065600.0, 0.0004)), new(0.00016014d, new GammaParticle(3085800.0, 0.0004)), new(0.013847400000000001d, new GammaParticle(3129100.0, 0.0004)), new(4.71e-05d, new GammaParticle(3400800.0, 0.00036)), new(4.71e-05d, new GammaParticle(3447000.0, 0.00036)), new(0.0005652d, new GammaParticle(3512500.0, 0.00035)), new(6.594e-05d, new GammaParticle(3640600.0, 0.00034)), new(0.000471d, new GammaParticle(3793100.0, 0.00033)), new(0.00015072d, new GammaParticle(3892700.0, 0.00032)), new(6.594e-05d, new GammaParticle(4136200.0, 0.0003)), new(1.4030532d, new GammaParticle(511000.0, 0.00243)), new(0.011399999999999999d, new GammaParticle(2440.0, 0.50813)), new(0.0574d, new GammaParticle(17374.0, 0.07136)), new(0.1094d, new GammaParticle(17479.0, 0.07093)), new(0.0287d, new GammaParticle(19681.0, 0.063)), new(0.0331d, new GammaParticle(19794.0, 0.06264)), new(0.00442d, new GammaParticle(19963.0, 0.06211)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium94()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    