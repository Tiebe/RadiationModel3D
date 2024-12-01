using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium207m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium207m";
        public override double halfLife { get; } = 0.059d;
        public override double atomicWeight { get; } = 207.00437d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium207()) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon203()), new(1.0d, new AlphaParticle(8852002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    