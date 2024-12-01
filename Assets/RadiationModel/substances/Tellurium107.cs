using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium107";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 106.93488d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin103()), new(1.0d, new AlphaParticle(5027002.09)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin107()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    