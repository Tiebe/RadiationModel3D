using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium156";
        public override double halfLife { get; } = 0.494d;
        public override double atomicWeight { get; } = 155.95309d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium152()), new(1.0d, new AlphaParticle(6617002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    