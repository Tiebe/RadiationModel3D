using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium96n : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium96n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 95.93535d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium96() }, { 0.07d, new GammaParticle(38000.0, 0.03263) }, { 0.07d, new GammaParticle(38000.0, 0.03263) }, { 0.036000000000000004d, new GammaParticle(40000.0, 0.031) }, { 0.17d, new GammaParticle(59300.0, 0.02091) }, { 0.08d, new GammaParticle(89500.0, 0.01385) }, { 0.37d, new GammaParticle(92800.0, 0.01336) }, { 0.36d, new GammaParticle(116800.0, 0.01062) }, { 0.32d, new GammaParticle(122000.0, 0.01016) }, { 0.36d, new GammaParticle(123500.0, 0.01004) }, { 0.07d, new GammaParticle(126000.0, 0.00984) }, { 0.07d, new GammaParticle(148800.0, 0.00833) }, { 0.07d, new GammaParticle(166100.0, 0.00746) }, { 0.12d, new GammaParticle(177600.0, 0.00698) }, { 0.12d, new GammaParticle(185400.0, 0.00669) }, { 0.16d, new GammaParticle(209900.0, 0.00591) }, { 0.42d, new GammaParticle(240300.0, 0.00516) }, { 0.05d, new GammaParticle(276300.0, 0.00449) }, { 0.68d, new GammaParticle(300000.0, 0.00413) }, { 0.17d, new GammaParticle(301000.0, 0.00412) }, { 0.07d, new GammaParticle(329000.0, 0.00377) }, { 0.1d, new GammaParticle(366800.0, 0.00338) }, { 0.13d, new GammaParticle(369200.0, 0.00336) }, { 0.03d, new GammaParticle(402400.0, 0.00308) }, { 0.04d, new GammaParticle(405500.0, 0.00306) }, { 0.48d, new GammaParticle(461600.0, 0.00269) }, { 0.05d, new GammaParticle(495200.0, 0.0025) }, { 0.05d, new GammaParticle(554500.0, 0.00224) }, { 0.03307238067d, new GammaParticle(1767.0, 0.70166) }, { 0.19543802334162166d, new GammaParticle(13336.0, 0.09297) }, { 0.37620408727934873d, new GammaParticle(13396.0, 0.09255) }, { 0.09158567148658557d, new GammaParticle(15021.0, 0.08254) }, { 0.10220960937902951d, new GammaParticle(15070.0, 0.08227) }, { 0.010623937892443926d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    