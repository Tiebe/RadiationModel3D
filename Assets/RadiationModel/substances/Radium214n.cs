using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium214n : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 214.0021d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9991d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium214()) } },
            { 0.9991d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon214()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0009d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon210()), new(1.0d, new AlphaParticle(10160002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    