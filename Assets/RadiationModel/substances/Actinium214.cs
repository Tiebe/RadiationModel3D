using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium214";
        public override double halfLife { get; } = 8.2d;
        public override double atomicWeight { get; } = 214.00691d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium210()), new(1.0d, new AlphaParticle(8374002.09)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium214()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    