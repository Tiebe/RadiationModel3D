using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium250";
        public override double halfLife { get; } = 412764591.74766d;
        public override double atomicWeight { get; } = 250.0764d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9992300000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium246()), new(1.0d, new AlphaParticle(7150402.09)), new(0.00016299999999999998d, new GammaParticle(42852.0, 0.02893)), new(0.06752438d, new GammaParticle(18579.0, 0.06673)) } },
            { 0.00077d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    