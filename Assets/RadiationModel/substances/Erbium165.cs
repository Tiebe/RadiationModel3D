using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium165";
        public override double halfLife { get; } = 37296.0d;
        public override double atomicWeight { get; } = 164.93073d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium165()), new(0.16964612939999998d, new GammaParticle(7656.0, 0.16194)), new(0.21419843526540572d, new GammaParticle(46700.0, 0.02655)), new(0.3814753967326905d, new GammaParticle(47547.0, 0.02608)), new(0.12324775238246324d, new GammaParticle(53982.0, 0.02297)), new(0.15529216800190368d, new GammaParticle(54577.0, 0.02272)), new(0.03204441561944044d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    