using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium183";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 182.96243d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium183()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    