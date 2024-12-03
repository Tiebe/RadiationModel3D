using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium50m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50m";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 49.95246d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium50()), new(0.963d, new GammaParticle(256894.0, 0.00483)), new(0.000139952243016d, new GammaParticle(422.0, 2.93801)), new(0.0018005997657528617d, new GammaParticle(4086.0, 0.30344)), new(0.00355217945502636d, new GammaParticle(4091.0, 0.30307)), new(0.0007060315792207793d, new GammaParticle(4474.0, 0.27712)), new(0.0007060315792207793d, new GammaParticle(4474.0, 0.27712)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium50()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    