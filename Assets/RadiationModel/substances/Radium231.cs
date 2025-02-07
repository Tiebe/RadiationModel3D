using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium231";
        public override double halfLife { get; } = 103.9d;
        public override double atomicWeight { get; } = 231.04103d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium231()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    