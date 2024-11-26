using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium246";
        public override double halfLife { get; } = 148506893636.42996d;
        public override double atomicWeight { get; } = 246.06722d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9997385d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium242()), new(1.0d, new AlphaParticle(6497002.09)), new(0.000279d, new GammaParticle(44545.0, 0.02783)), new(0.078929937d, new GammaParticle(17604.0, 0.07043)) } },
            { 0.0002615d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    