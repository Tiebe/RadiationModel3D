using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium237";
        public override double halfLife { get; } = 522.0d;
        public override double atomicWeight { get; } = 237.05102d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium237() }, { 1.0d, new BetaParticle(-1, 1068950.0) }, { 0.00017732000000000002d, new GammaParticle(45000.0, 0.02755) }, { 0.0017050000000000001d, new GammaParticle(179100.0, 0.00692) }, { 0.017391d, new GammaParticle(310100.0, 0.004) }, { 0.024211d, new GammaParticle(498700.0, 0.00249) }, { 0.15004d, new GammaParticle(529400.0, 0.00234) }, { 0.09207000000000001d, new GammaParticle(540700.0, 0.00229) }, { 0.002387d, new GammaParticle(543600.0, 0.00228) }, { 0.015345d, new GammaParticle(554900.0, 0.00223) }, { 0.001364d, new GammaParticle(701000.0, 0.00177) }, { 0.008184d, new GammaParticle(722600.0, 0.00172) }, { 0.006479d, new GammaParticle(734000.0, 0.00169) }, { 0.005115d, new GammaParticle(847100.0, 0.00146) }, { 0.341d, new GammaParticle(853700.0, 0.00145) }, { 0.15686d, new GammaParticle(865000.0, 0.00143) }, { 0.0017050000000000001d, new GammaParticle(1333200.0, 0.00093) }, { 0.001023d, new GammaParticle(1344800.0, 0.00092) }, { 0.0017050000000000001d, new GammaParticle(1395900.0, 0.00089) }, { 0.001023d, new GammaParticle(1407500.0, 0.00088) }, { 0.01888072139404d, new GammaParticle(16678.0, 0.07434) }, { 0.004406581413265239d, new GammaParticle(94657.0, 0.0131) }, { 0.007053916140972049d, new GammaParticle(98439.0, 0.0126) }, { 0.002544879486708429d, new GammaParticle(111238.0, 0.01115) }, { 0.003415228271162712d, new GammaParticle(112645.0, 0.01101) }, { 0.0008703487844542827d, new GammaParticle(114446.0, 0.01083) } } },

        };
    }
}
    