using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium122p : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122p";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 121.91625d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium122() }, { 0.01664d, new GammaParticle(45850.0, 0.02704) }, { 0.047008d, new GammaParticle(81200.0, 0.01527) }, { 0.1332361691648d, new GammaParticle(4749.0, 0.26107) }, { 0.22376243911147614d, new GammaParticle(30625.0, 0.04048) }, { 0.41337971385826d, new GammaParticle(30973.0, 0.04003) }, { 0.12077019266098374d, new GammaParticle(35089.0, 0.03533) }, { 0.15023811967026376d, new GammaParticle(35414.0, 0.03501) }, { 0.02946792700928003d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    