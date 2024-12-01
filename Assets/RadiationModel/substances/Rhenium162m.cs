using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium162m";
        public override double halfLife { get; } = 0.077d;
        public override double atomicWeight { get; } = 161.97608d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum158()), new(1.0d, new AlphaParticle(7437002.09)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    