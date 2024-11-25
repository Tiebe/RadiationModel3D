using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium137m";
        public override double halfLife { get; } = 123840.0d;
        public override double atomicWeight { get; } = 136.90804d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9921d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium137() }, { 0.111d, new GammaParticle(254290.0, 0.00488) }, { 0.09288202500000001d, new GammaParticle(5410.0, 0.22918) }, { 0.15624960401578677d, new GammaParticle(34279.0, 0.03617) }, { 0.2861714359263494d, new GammaParticle(34720.0, 0.03571) }, { 0.08619095698394247d, new GammaParticle(39366.0, 0.0315) }, { 0.10808346005786387d, new GammaParticle(39753.0, 0.03119) }, { 0.021892503073921387d, new GammaParticle(40229.0, 0.03082) } } },
            { 0.0079d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium137() }, { 1.0d, new BetaParticle(1, 1028450.0) }, { 8.999999999999999e-05d, new GammaParticle(87200.0, 0.01422) }, { 0.0045000000000000005d, new GammaParticle(169260.0, 0.00733) }, { 0.00196d, new GammaParticle(762300.0, 0.00163) }, { 0.0045000000000000005d, new GammaParticle(824820.0, 0.0015) }, { 0.00105d, new GammaParticle(835380.0, 0.00148) }, { 2.8e-05d, new GammaParticle(906840.0, 0.00137) }, { 0.000131d, new GammaParticle(917450.0, 0.00135) }, { 2e-05d, new GammaParticle(993810.0, 0.00125) }, { 0.00023d, new GammaParticle(1004490.0, 0.00123) }, { 3.397215979989e-05d, new GammaParticle(5185.0, 0.23912) }, { 7.323224368620635e-05d, new GammaParticle(33034.0, 0.03753) }, { 0.0001345191838468155d, new GammaParticle(33442.0, 0.03707) }, { 4.005805657779577e-05d, new GammaParticle(37908.0, 0.03271) }, { 5.0192744891978086e-05d, new GammaParticle(38273.0, 0.03239) }, { 1.0134688314182328e-05d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    