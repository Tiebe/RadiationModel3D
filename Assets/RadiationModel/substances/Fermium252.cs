using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium252";
        public override double halfLife { get; } = 91404.0d;
        public override double atomicWeight { get; } = 252.08247d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999769999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium248()), new(1.0d, new AlphaParticle(8176002.09)), new(0.00010899999999999999d, new GammaParticle(41530.0, 0.02985)), new(0.00035999999999999997d, new GammaParticle(96280.0, 0.01288)), new(0.068740112d, new GammaParticle(19579.0, 0.06333)) } },
            { 2.3e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    