using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium113m";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 112.91035d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium113()), new(0.069d, new GammaParticle(81100.0, 0.01529)), new(0.024206028d, new GammaParticle(3053.0, 0.40611)), new(0.08740100604330626d, new GammaParticle(21020.0, 0.05898)), new(0.16512564905215615d, new GammaParticle(21177.0, 0.05855)), new(0.04530371359362185d, new GammaParticle(23904.0, 0.05187)), new(0.053005344904537566d, new GammaParticle(24070.0, 0.05151)), new(0.007701631310915714d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    