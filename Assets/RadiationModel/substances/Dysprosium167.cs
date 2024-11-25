using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium167";
        public override double halfLife { get; } = 372.0d;
        public override double atomicWeight { get; } = 166.93568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium167() }, { 1.0d, new BetaParticle(-1, 1184000.0) }, { 0.0092d, new GammaParticle(60440.0, 0.02051) }, { 0.0015d, new GammaParticle(72670.0, 0.01706) }, { 0.0043d, new GammaParticle(90260.0, 0.01374) }, { 0.031d, new GammaParticle(133190.0, 0.00931) }, { 0.0068000000000000005d, new GammaParticle(150580.0, 0.00823) }, { 0.0048d, new GammaParticle(159710.0, 0.00776) }, { 0.096d, new GammaParticle(250030.0, 0.00496) }, { 0.28d, new GammaParticle(259330.0, 0.00478) }, { 0.251d, new GammaParticle(310260.0, 0.004) }, { 0.0101d, new GammaParticle(352200.0, 0.00352) }, { 0.483d, new GammaParticle(569700.0, 0.00218) }, { 0.0023d, new GammaParticle(579400.0, 0.00214) }, { 0.008199999999999999d, new GammaParticle(599200.0, 0.00207) }, { 0.0034000000000000002d, new GammaParticle(662900.0, 0.00187) }, { 0.0024d, new GammaParticle(689400.0, 0.0018) }, { 0.0097d, new GammaParticle(707100.0, 0.00175) }, { 0.0058d, new GammaParticle(738800.0, 0.00168) }, { 0.0041538d, new GammaParticle(746000.0, 0.00166) }, { 0.0038640000000000002d, new GammaParticle(799000.0, 0.00155) }, { 0.0034000000000000002d, new GammaParticle(830800.0, 0.00149) }, { 0.0048d, new GammaParticle(848300.0, 0.00146) }, { 0.0039000000000000003d, new GammaParticle(909100.0, 0.00136) }, { 0.0024d, new GammaParticle(920500.0, 0.00135) }, { 0.0024d, new GammaParticle(981400.0, 0.00126) }, { 0.0046d, new GammaParticle(997000.0, 0.00124) }, { 0.0029946d, new GammaParticle(1080300.0, 0.00115) }, { 0.0024d, new GammaParticle(1094600.0, 0.00113) }, { 0.0031d, new GammaParticle(1272900.0, 0.00097) }, { 0.0023d, new GammaParticle(1405600.0, 0.00088) }, { 0.08164515999272d, new GammaParticle(7656.0, 0.16194) }, { 0.09225475396590457d, new GammaParticle(46700.0, 0.02655) }, { 0.16430054134622363d, new GammaParticle(47547.0, 0.02608) }, { 0.05308251229196176d, new GammaParticle(53982.0, 0.02297) }, { 0.06688396548787182d, new GammaParticle(54577.0, 0.02272) }, { 0.013801453195910059d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    