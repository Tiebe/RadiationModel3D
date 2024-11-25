using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium116";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 115.90847d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin116() }, { 1.0d, new BetaParticle(1, 3130990.0) }, { 0.33072d, new GammaParticle(93700.0, 0.01323) }, { 0.019822d, new GammaParticle(103000.0, 0.01204) }, { 0.0004982000000000001d, new GammaParticle(108500.0, 0.01143) }, { 0.004346d, new GammaParticle(157200.0, 0.00789) }, { 0.002332d, new GammaParticle(180900.0, 0.00685) }, { 0.0006254d, new GammaParticle(363000.0, 0.00342) }, { 0.001378d, new GammaParticle(366800.0, 0.00338) }, { 0.00053d, new GammaParticle(447800.0, 0.00277) }, { 0.00106d, new GammaParticle(457200.0, 0.00271) }, { 7.42e-05d, new GammaParticle(466000.0, 0.00266) }, { 0.0004452d, new GammaParticle(471400.0, 0.00263) }, { 0.003922d, new GammaParticle(480600.0, 0.00258) }, { 0.003074d, new GammaParticle(550900.0, 0.00225) }, { 0.0003816d, new GammaParticle(574500.0, 0.00216) }, { 0.0009222d, new GammaParticle(583800.0, 0.00212) }, { 0.032118d, new GammaParticle(628700.0, 0.00197) }, { 0.007526000000000001d, new GammaParticle(637900.0, 0.00194) }, { 0.001166d, new GammaParticle(824000.0, 0.0015) }, { 0.001484d, new GammaParticle(917700.0, 0.00135) }, { 0.0050880000000000005d, new GammaParticle(1055300.0, 0.00117) }, { 0.002014d, new GammaParticle(1064600.0, 0.00116) }, { 0.012d, new GammaParticle(511000.0, 0.00243) }, { 0.1209842341842d, new GammaParticle(3941.0, 0.3146) }, { 0.33168254887017085d, new GammaParticle(26111.0, 0.04748) }, { 0.6192728694364653d, new GammaParticle(26359.0, 0.04704) }, { 0.17616705180891784d, new GammaParticle(29821.0, 0.04158) }, { 0.21263363153336384d, new GammaParticle(30069.0, 0.04123) }, { 0.036466579724445995d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    