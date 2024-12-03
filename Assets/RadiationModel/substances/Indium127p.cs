using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium127p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 126.92d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium127()), new(0.0405d, new GammaParticle(47000.0, 0.02638)), new(0.055683236159999996d, new GammaParticle(3571.0, 0.3472)), new(0.10528765315465732d, new GammaParticle(24001.0, 0.05166)), new(0.19753781079673044d, new GammaParticle(24209.0, 0.05121)), new(0.055424694158497684d, new GammaParticle(27367.0, 0.0453)), new(0.06595538604861224d, new GammaParticle(27581.0, 0.04495)), new(0.01053069189011456d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    