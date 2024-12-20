using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium200";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 199.98009d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium200()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    