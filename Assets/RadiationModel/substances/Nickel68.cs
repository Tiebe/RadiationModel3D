using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel68 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel68";
        public override double halfLife { get; } = 29.0d;
        public override double atomicWeight { get; } = 67.93187d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copper68()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    