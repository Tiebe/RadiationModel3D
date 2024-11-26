using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum31 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum31";
        public override double halfLife { get; } = 0.644d;
        public override double atomicWeight { get; } = 30.98395d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silicon31()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.053d, new GammaParticle(621810.0, 0.00199)), new(0.12300000000000001d, new GammaParticle(752230.0, 0.00165)), new(0.109d, new GammaParticle(1564490.0, 0.00079)), new(0.19d, new GammaParticle(1694730.0, 0.00073)), new(0.3d, new GammaParticle(2316640.0, 0.00054)), new(0.015d, new GammaParticle(2787600.0, 0.00044)), new(3.583924575e-09d, new GammaParticle(118.0, 10.50714)), new(5.436746713209457e-08d, new GammaParticle(1740.0, 0.71255)), new(1.0793620633729318e-07d, new GammaParticle(1740.0, 0.71255)), new(4.706806530612245e-09d, new GammaParticle(1836.0, 0.6753)), new(4.706806530612245e-09d, new GammaParticle(1836.0, 0.6753)) } },
            { 0.016d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silicon31()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.053d, new GammaParticle(621810.0, 0.00199)), new(0.12300000000000001d, new GammaParticle(752230.0, 0.00165)), new(0.109d, new GammaParticle(1564490.0, 0.00079)), new(0.19d, new GammaParticle(1694730.0, 0.00073)), new(0.3d, new GammaParticle(2316640.0, 0.00054)), new(0.015d, new GammaParticle(2787600.0, 0.00044)), new(3.583924575e-09d, new GammaParticle(118.0, 10.50714)), new(5.436746713209457e-08d, new GammaParticle(1740.0, 0.71255)), new(1.0793620633729318e-07d, new GammaParticle(1740.0, 0.71255)), new(4.706806530612245e-09d, new GammaParticle(1836.0, 0.6753)), new(4.706806530612245e-09d, new GammaParticle(1836.0, 0.6753)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    