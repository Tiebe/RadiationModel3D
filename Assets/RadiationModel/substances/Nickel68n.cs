using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel68n : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel68n";
        public override double halfLife { get; } = 0.00086d;
        public override double atomicWeight { get; } = 67.93493d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel68() }, { 0.9990730000000001d, new GammaParticle(815000.0, 0.00152) }, { 0.999617d, new GammaParticle(2033200.0, 0.00061) }, { 1.1011514460068638e-05d, new GammaParticle(874.0, 1.41858) }, { 0.0001104182161885603d, new GammaParticle(7461.0, 0.16618) }, { 0.0002154922251923503d, new GammaParticle(7478.0, 0.1658) }, { 4.4910458822289477e-05d, new GammaParticle(8296.0, 0.14945) }, { 4.4910458822289477e-05d, new GammaParticle(8296.0, 0.14945) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    