using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine77m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine77m";
        public override double halfLife { get; } = 256.8d;
        public override double atomicWeight { get; } = 76.92149d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine77()), new(0.13699999999999998d, new GammaParticle(105870.0, 0.01171)), new(0.018418288220000002d, new GammaParticle(1535.0, 0.80771)), new(0.12189356664340677d, new GammaParticle(11879.0, 0.10437)), new(0.2352703467350063d, new GammaParticle(11925.0, 0.10397)), new(0.05580271687856194d, new GammaParticle(13345.0, 0.09291)), new(0.060110686621586924d, new GammaParticle(13377.0, 0.09268)), new(0.004307969743024982d, new GammaParticle(13469.0, 0.09205)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    