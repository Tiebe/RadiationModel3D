using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium164";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 163.93592d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium164()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    