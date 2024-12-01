using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver107m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver107m";
        public override double halfLife { get; } = 44.3d;
        public override double atomicWeight { get; } = 106.90519d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver107()), new(0.0467d, new GammaParticle(93124.0, 0.01331)), new(0.0487672814156d, new GammaParticle(3218.0, 0.38528)), new(0.10417267195424985d, new GammaParticle(21990.0, 0.05638)), new(0.19636695938595636d, new GammaParticle(22163.0, 0.05594)), new(0.05439920925025028d, new GammaParticle(25030.0, 0.04953)), new(0.06386467165979383d, new GammaParticle(25211.0, 0.04918)), new(0.00946546240954355d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    