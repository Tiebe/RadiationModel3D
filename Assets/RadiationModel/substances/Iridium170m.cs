using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium170m";
        public override double halfLife { get; } = 0.811d;
        public override double atomicWeight { get; } = 169.97516d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.62d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium170()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.62d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium170()) } },
            { 0.38d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium166()), new(1.0d, new AlphaParticle(7297002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    