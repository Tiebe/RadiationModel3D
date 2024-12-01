using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium126p : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium126p";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 125.94699d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.72d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver126()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.28d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium126()), new(0.28d, new GammaParticle(296700.0, 0.00418)), new(0.15d, new GammaParticle(542400.0, 0.00229)), new(0.25d, new GammaParticle(693300.0, 0.00179)), new(0.14d, new GammaParticle(787700.0, 0.00157)), new(0.13d, new GammaParticle(1330200.0, 0.00093)), new(0.0017143178110000002d, new GammaParticle(3053.0, 0.40611)), new(0.006367998361595478d, new GammaParticle(21020.0, 0.05898)), new(0.012030981223494197d, new GammaParticle(21177.0, 0.05855)), new(0.003300808388812242d, new GammaParticle(23904.0, 0.05187)), new(0.003861945814910323d, new GammaParticle(24070.0, 0.05151)), new(0.0005611374260980812d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    