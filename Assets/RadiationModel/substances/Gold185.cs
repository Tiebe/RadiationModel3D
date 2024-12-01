using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold185 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold185";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 184.9658d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9974d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium185()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0026d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium181()), new(1.0d, new AlphaParticle(6201902.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    