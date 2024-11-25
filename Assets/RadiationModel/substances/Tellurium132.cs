using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium132";
        public override double halfLife { get; } = 276825.6d;
        public override double atomicWeight { get; } = 131.90855d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine132() }, { 1.0d, new BetaParticle(-1, 258000.0) }, { 0.1496d, new GammaParticle(49720.0, 0.02494) }, { 0.017424d, new GammaParticle(111760.0, 0.01109) }, { 0.019624d, new GammaParticle(116300.0, 0.01066) }, { 0.88d, new GammaParticle(228160.0, 0.00543) }, { 0.07934537561632d, new GammaParticle(4335.0, 0.28601) }, { 0.20675625756214114d, new GammaParticle(28318.0, 0.04378) }, { 0.3840197948776767d, new GammaParticle(28613.0, 0.04333) }, { 0.11063799481254662d, new GammaParticle(32395.0, 0.03827) }, { 0.13564218164018216d, new GammaParticle(32680.0, 0.03794) }, { 0.025004186827635534d, new GammaParticle(33040.0, 0.03753) } } },

        };
    }
}
    