using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese52m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese52m";
        public override double halfLife { get; } = 1266.0d;
        public override double atomicWeight { get; } = 51.94596d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9822d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium52()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00028000000000000003d, new GammaParticle(704600.0, 0.00176)), new(0.0002d, new GammaParticle(935520.0, 0.00133)), new(0.00029d, new GammaParticle(1332620.0, 0.00093)), new(0.982d, new GammaParticle(1434060.0, 0.00086)), new(0.00046199999999999995d, new GammaParticle(1530670.0, 0.00081)), new(0.00216d, new GammaParticle(1727530.0, 0.00072)), new(7.900000000000001e-05d, new GammaParticle(2038000.0, 0.00061)), new(6.9e-05d, new GammaParticle(2337400.0, 0.00053)), new(5.999999999999999e-06d, new GammaParticle(2847700.0, 0.00044)), new(4e-06d, new GammaParticle(2965000.0, 0.00042)), new(1.4733e-06d, new GammaParticle(3129000.0, 0.0004)), new(0.00021999999999999998d, new GammaParticle(3161800.0, 0.00039)), new(2.5e-05d, new GammaParticle(3381500.0, 0.00037)), new(1.8e-05d, new GammaParticle(3771700.0, 0.00033)), new(7e-06d, new GammaParticle(3951000.0, 0.00031)), new(2.5e-05d, new GammaParticle(4815400.0, 0.00026)), new(1.932233016d, new GammaParticle(511000.0, 0.00243)), new(0.00010800000000000001d, new GammaParticle(597.0, 2.07679)), new(0.00128d, new GammaParticle(5406.0, 0.22935)), new(0.00251d, new GammaParticle(5415.0, 0.22896)), new(0.000511d, new GammaParticle(5966.0, 0.20782)), new(0.000511d, new GammaParticle(5966.0, 0.20782)) } },
            { 0.0178d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese52()), new(0.0168d, new GammaParticle(377738.0, 0.00328)), new(4.456249728e-06d, new GammaParticle(660.0, 1.87855)), new(5.707698700680448e-05d, new GammaParticle(5888.0, 0.21057)), new(0.0001119376093485085d, new GammaParticle(5899.0, 0.21018)), new(2.296908364468704e-05d, new GammaParticle(6512.0, 0.19039)), new(2.296908364468704e-05d, new GammaParticle(6512.0, 0.19039)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    