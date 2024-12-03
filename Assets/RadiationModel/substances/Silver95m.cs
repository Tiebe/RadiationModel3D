using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver95m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95m";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 94.93605d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver95()), new(0.535d, new GammaParticle(77400.0, 0.01602)), new(0.8389d, new GammaParticle(266800.0, 0.00465)), new(0.03432011396d, new GammaParticle(3218.0, 0.38528)), new(0.1255023741449631d, new GammaParticle(21990.0, 0.05638)), new(0.23657374956637717d, new GammaParticle(22163.0, 0.05594)), new(0.0655376288659794d, new GammaParticle(25030.0, 0.04953)), new(0.0769411762886598d, new GammaParticle(25211.0, 0.04918)), new(0.011403547422680415d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    