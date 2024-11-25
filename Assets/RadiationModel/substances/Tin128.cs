using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin128 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128";
        public override double halfLife { get; } = 3544.2d;
        public override double atomicWeight { get; } = 127.91051d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony128() }, { 1.0d, new BetaParticle(-1, 634500.0) }, { 0.040119999999999996d, new GammaParticle(32100.0, 0.03862) }, { 0.1298d, new GammaParticle(45700.0, 0.02713) }, { 0.2773d, new GammaParticle(75100.0, 0.01651) }, { 0.0017699999999999999d, new GammaParticle(80900.0, 0.01533) }, { 0.0017699999999999999d, new GammaParticle(115900.0, 0.0107) }, { 0.0649d, new GammaParticle(152700.0, 0.00812) }, { 0.059000000000000004d, new GammaParticle(404400.0, 0.00307) }, { 0.041299999999999996d, new GammaParticle(436700.0, 0.00284) }, { 0.59d, new GammaParticle(482300.0, 0.00257) }, { 0.16519999999999999d, new GammaParticle(557300.0, 0.00222) }, { 0.1593d, new GammaParticle(680500.0, 0.00182) }, { 0.133548145392d, new GammaParticle(3941.0, 0.3146) }, { 0.39290933274361706d, new GammaParticle(26111.0, 0.04748) }, { 0.7335872530687397d, new GammaParticle(26359.0, 0.04704) }, { 0.2086865257561251d, new GammaParticle(29821.0, 0.04158) }, { 0.251884636587643d, new GammaParticle(30069.0, 0.04123) }, { 0.043198110831517894d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    