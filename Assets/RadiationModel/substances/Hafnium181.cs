using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium181";
        public override double halfLife { get; } = 3662496.0d;
        public override double atomicWeight { get; } = 180.94911d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum181() }, { 1.0d, new BetaParticle(-1, 518050.0) }, { 1.7e-05d, new GammaParticle(3900.0, 0.31791) }, { 0.000115115d, new GammaParticle(6300.0, 0.1968) }, { 0.43309d, new GammaParticle(133021.0, 0.00932) }, { 0.058523500000000006d, new GammaParticle(136260.0, 0.0091) }, { 0.0086135d, new GammaParticle(136860.0, 0.00906) }, { 0.151179d, new GammaParticle(345930.0, 0.00358) }, { 0.00702765d, new GammaParticle(475990.0, 0.0026) }, { 0.805d, new GammaParticle(482180.0, 0.00257) }, { 0.0023344999999999998d, new GammaParticle(615170.0, 0.00202) }, { 0.000250355d, new GammaParticle(618660.0, 0.002) }, { 0.14950873547566806d, new GammaParticle(9424.0, 0.13156) }, { 0.09051587458925688d, new GammaParticle(56280.0, 0.02203) }, { 0.15780312864235857d, new GammaParticle(57535.0, 0.02155) }, { 0.052205648710898694d, new GammaParticle(65315.0, 0.01898) }, { 0.06630117386284134d, new GammaParticle(66067.0, 0.01877) }, { 0.014095525151942647d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    