using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium174";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 173.95312d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum174() }, { 1.0d, new BetaParticle(1, 4034000.0) }, { 0.19848500000000002d, new GammaParticle(112400.0, 0.01103) }, { 0.365512d, new GammaParticle(243700.0, 0.00509) }, { 0.047936d, new GammaParticle(349100.0, 0.00355) }, { 0.012733000000000001d, new GammaParticle(533800.0, 0.00232) }, { 0.046438d, new GammaParticle(739300.0, 0.00168) }, { 0.01498d, new GammaParticle(759800.0, 0.00163) }, { 0.026215000000000002d, new GammaParticle(777200.0, 0.0016) }, { 0.017976000000000002d, new GammaParticle(863400.0, 0.00144) }, { 0.02996d, new GammaParticle(900000.0, 0.00138) }, { 0.037450000000000004d, new GammaParticle(903000.0, 0.00137) }, { 0.012733000000000001d, new GammaParticle(981800.0, 0.00126) }, { 0.056174999999999996d, new GammaParticle(1002900.0, 0.00124) }, { 0.025466000000000003d, new GammaParticle(1088200.0, 0.00114) }, { 0.121627903547115d, new GammaParticle(9740.0, 0.12729) }, { 0.0489295347701375d, new GammaParticle(57983.0, 0.02138) }, { 0.08499137531724422d, new GammaParticle(59320.0, 0.0209) }, { 0.028171745607078726d, new GammaParticle(67335.0, 0.01841) }, { 0.0358908039034183d, new GammaParticle(68117.0, 0.0182) }, { 0.00771905829633957d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    