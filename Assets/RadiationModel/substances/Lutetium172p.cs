using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium172p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172p";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 171.93921d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium172()), new(3.9e-05d, new GammaParticle(41860.0, 0.02962)), new(0.504d, new GammaParticle(67350.0, 0.01841)), new(0.28017552d, new GammaParticle(8810.0, 0.14073)), new(0.10974380779442411d, new GammaParticle(52965.0, 0.02341)), new(0.19273587600004233d, new GammaParticle(54070.0, 0.02293)), new(0.06341544003602342d, new GammaParticle(61387.0, 0.0202)), new(0.08015711620553362d, new GammaParticle(62084.0, 0.01997)), new(0.01674167616951018d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    