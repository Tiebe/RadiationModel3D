using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium200";
        public override double halfLife { get; } = 692.4d;
        public override double atomicWeight { get; } = 199.98181d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.887d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.113d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead196()), new(1.0d, new AlphaParticle(7003002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    