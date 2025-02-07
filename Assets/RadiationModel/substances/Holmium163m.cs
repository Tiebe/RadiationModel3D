using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium163m";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 162.92906d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium163()), new(0.777d, new GammaParticle(297880.0, 0.00416)), new(0.0369782772d, new GammaParticle(7656.0, 0.16194)), new(0.03169139447787077d, new GammaParticle(46700.0, 0.02655)), new(0.056440595686323716d, new GammaParticle(47547.0, 0.02608)), new(0.01823492844111548d, new GammaParticle(53982.0, 0.02297)), new(0.022976009835805503d, new GammaParticle(54577.0, 0.02272)), new(0.004741081394690024d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    