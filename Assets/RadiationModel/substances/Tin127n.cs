using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin127n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin127n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 126.91235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin127()), new(0.00036995d, new GammaParticle(16520.0, 0.07505)), new(0.024462d, new GammaParticle(184810.0, 0.00671)), new(0.15402d, new GammaParticle(567260.0, 0.00219)), new(0.02718d, new GammaParticle(646340.0, 0.00192)), new(0.6795d, new GammaParticle(715520.0, 0.00173)), new(0.14194d, new GammaParticle(732040.0, 0.00169)), new(0.02718d, new GammaParticle(979100.0, 0.00127)), new(0.8154d, new GammaParticle(1094700.0, 0.00113)), new(0.15402d, new GammaParticle(1242710.0, 0.001)), new(0.0513642235179688d, new GammaParticle(3753.0, 0.33036)), new(0.0005335728186458774d, new GammaParticle(25044.0, 0.04951)), new(0.0009986390017703115d, new GammaParticle(25271.0, 0.04906)), new(0.000282377550195331d, new GammaParticle(28579.0, 0.04338)), new(0.00033800592758381125d, new GammaParticle(28810.0, 0.04304)), new(5.562837738848021e-05d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    