using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium186";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 185.9609d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum186()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    