using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium138m";
        public override double halfLife { get; } = 174.6d;
        public override double atomicWeight { get; } = 137.9111d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium138() }, { 0.00378d, new GammaParticle(79900.0, 0.01552) }, { 0.0704591784d, new GammaParticle(4749.0, 0.26107) }, { 0.1148310654521644d, new GammaParticle(30625.0, 0.04048) }, { 0.2121394152081367d, new GammaParticle(30973.0, 0.04003) }, { 0.061977202041558675d, new GammaParticle(35089.0, 0.03533) }, { 0.07709963933969899d, new GammaParticle(35414.0, 0.03501) }, { 0.015122437298140319d, new GammaParticle(35818.0, 0.03462) } } },
            { 0.19d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium138() }, { 1.0d, new BetaParticle(-1, 2727405.0) }, { 0.0019d, new GammaParticle(107500.0, 0.01153) }, { 0.015d, new GammaParticle(112500.0, 0.01102) }, { 0.15d, new GammaParticle(191700.0, 0.00647) }, { 0.0053d, new GammaParticle(212000.0, 0.00585) }, { 0.012d, new GammaParticle(324500.0, 0.00382) }, { 0.19d, new GammaParticle(463000.0, 0.00268) }, { 0.0060999999999999995d, new GammaParticle(516200.0, 0.0024) }, { 0.19d, new GammaParticle(1436000.0, 0.00086) }, { 0.00439811139284d, new GammaParticle(4966.0, 0.24967) }, { 0.009353775622297073d, new GammaParticle(31816.0, 0.03897) }, { 0.01723245324667847d, new GammaParticle(32193.0, 0.03851) }, { 0.005068796190914108d, new GammaParticle(36482.0, 0.03399) }, { 0.006346132831024463d, new GammaParticle(36827.0, 0.03367) }, { 0.0012773366401103554d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    